
// PIC16F18877 Configuration Bit Settings

// 'C' source line config statements

// CONFIG1
#pragma config FEXTOSC = OFF    // External Oscillator mode selection bits (Oscillator not enabled)
#pragma config RSTOSC = HFINT1  // Power-up default value for COSC bits (HFINTOSC (1MHz))
#pragma config CLKOUTEN = OFF   // Clock Out Enable bit (CLKOUT function is disabled; i/o or oscillator function on OSC2)
#pragma config CSWEN = ON       // Clock Switch Enable bit (Writing to NOSC and NDIV is allowed)
#pragma config FCMEN = ON       // Fail-Safe Clock Monitor Enable bit (FSCM timer enabled)

// CONFIG2
#pragma config MCLRE = ON       // Master Clear Enable bit (MCLR pin is Master Clear function)
#pragma config PWRTE = OFF      // Power-up Timer Enable bit (PWRT disabled)
#pragma config LPBOREN = OFF    // Low-Power BOR enable bit (ULPBOR disabled)
#pragma config BOREN = ON       // Brown-out reset enable bits (Brown-out Reset Enabled, SBOREN bit is ignored)
#pragma config BORV = LO        // Brown-out Reset Voltage Selection (Brown-out Reset Voltage (VBOR) set to 1.9V on LF, and 2.45V on F Devices)
#pragma config ZCD = OFF        // Zero-cross detect disable (Zero-cross detect circuit is disabled at POR.)
#pragma config PPS1WAY = ON     // Peripheral Pin Select one-way control (The PPSLOCK bit can be cleared and set only once in software)
#pragma config STVREN = ON      // Stack Overflow/Underflow Reset Enable bit (Stack Overflow or Underflow will cause a reset)

// CONFIG3
#pragma config WDTCPS = WDTCPS_31// WDT Period Select bits (Divider ratio 1:65536; software control of WDTPS)
#pragma config WDTE = OFF       // WDT operating mode (WDT Disabled, SWDTEN is ignored)
#pragma config WDTCWS = WDTCWS_7// WDT Window Select bits (window always open (100%); software control; keyed access not required)
#pragma config WDTCCS = SC      // WDT input clock selector (Software Control)

// CONFIG4
#pragma config WRT = OFF        // UserNVM self-write protection bits (Write protection off)
#pragma config SCANE = available// Scanner Enable bit (Scanner module is available for use)
#pragma config LVP = ON         // Low Voltage Programming Enable bit (Low Voltage programming enabled. MCLR/Vpp pin function is MCLR.)

// CONFIG5
#pragma config CP = OFF         // UserNVM Program memory code protection bit (Program Memory code protection disabled)
#pragma config CPD = OFF        // DataNVM code protection bit (Data EEPROM code protection disabled)

// #pragma config statements should precede project file includes.
// Use project enums instead of #define for ON and OFF.


#include <xc.h>
#include <stdint.h>
#include <stdio.h>

// LCD module connections
#define LCD_RS PORTCbits.RC0  //
#define LCD_EN PORTCbits.RC3
#define LCD_D4 PORTCbits.RC4
#define LCD_D5 PORTCbits.RC5
#define LCD_D6 PORTCbits.RC6
#define LCD_D7 PORTCbits.RC7
#define LCD_DATA_PORT PORTC
#define _XTAL_FREQ  4000000

// Function prototypes
void LCD_Init();
void LCD_Cmd(unsigned char);
void LCD_Char(unsigned char);
void LCD_String(const char*);
void LCD_Clear();
void LCD_Send(int RS,unsigned char data);
void lcd_set_cursor(char col,char line);
void ADC_Init();
unsigned int ADC_Read(uint8_t channel);

//O2 Lvl = 3543 %
//PH lvl = 3432 %
static int sec =0;
void main(void) {
    char name[16] = "Aung Win Htut";
    char buffer[16];
    int i = 32;
    ADC_Init();
    LCD_Init();
    LCD_Clear();
    while (1) {
        unsigned int O2_level = ADC_Read(0);
        O2_level = O2_level * 100 / 1023;
        sprintf(buffer, "Oxygen lvl = %3u%%", O2_level);
                  
        //LCD_Cmd(0x00);
        lcd_set_cursor(1,1);
        LCD_String(buffer);
        __delay_ms(100); 
        
        unsigned int PH_level = ADC_Read(1);
        PH_level = PH_level * 14 / 1023;
        sprintf(buffer, "PH lvl = %3u%%", PH_level);
        lcd_set_cursor(1,2);
        LCD_String(buffer);
        __delay_ms(100);        
    }
    return;
}

void Timer0_Init() {
    // Set Timer0 to 16-bit mode and use the internal clock (Fosc/4)
    T0CON0 = 0b10000000; // 16-bit mode, Fosc/4    
    // Set the prescaler to 1:256, so each Timer0 tick is 256 instruction cycles
    T0CON1 = 0b00000110; // 1:256 prescaler    
    // Load Timer0 with the initial value to achieve a 1-minute delay
    TMR0H = 0x85; // High byte
    TMR0L = 0xEE; // Low byte
}
void __interrupt()isr(void) //timer on interrupt
{
    if(PIR0bits.TMR0IF==1)   //Timer 0 time up
    {
        PIR0bits.TMR0IF=0;   //Timer 0 OFF 
       //To DO
        sec++;
        //sevenseg_show(sec);
        if(sec == 7 )
        {
            PORTB=~PORTB;
            sec=0;
        }
    }
   
    
    
}

void timer(void)
{
    INTCONbits.GIE = 0;
    T0CON0 = 0b10000100;
    T0CON1 = 0b01001011;
    TMR0H = 200;//0xC8;
    PIR0bits.TMR0IF = 0; //to sure timer flage is off
    PIE0bits.TMR0IE = 1;
    INTCONbits.GIE = 1;


}


void ADC_Init() {
    // Configure ADC module settings
    // Set the ADC channel to ANA3 (RA3)
    ANSELA = 0b00000011; //RA0 and RA1
    TRISA =  0b11111111; //all inputs (including digital inputs)
    ADREF =  0b00000000; // VREF to VDD and VSS
    ADCLK =  0b00000011; // Set TAD = 2 us
    ADACQ =  0b00000000;
    ADCON0 = 0b10000100;  
    // Optional: Allow the ADC to stabilize before reading the first value
    __delay_us(20);
}
unsigned int ADC_Read(uint8_t channel) {    
    unsigned int result;
     ADPCH = channel; //0b00000011; //RA3 = 3
    __delay_us(2);
    
    ADCON0bits.GO = 1; //Start  
    // Wait for the conversion to complete
    while (ADCON0bits.GO); //while (ADCON0bits.ADGO==1); 
    result = ((unsigned int)ADRESH << 8) | ADRESL; // ADRESH * 256 + ADRESL;
    // Return the ADC result (combine ADRESH and ADRESL)
    return(result);
}

void LCD_Init() {
  
    TRISC = 0x00; //all C port pins are output
    __delay_ms(15);

    LCD_Cmd(0x02);  // Return home
    LCD_Cmd(0x28);  // 4-bit mode - 2 line display - 5x7 font
    LCD_Cmd(0x0C);  // Display ON - Cursor OFF - Blink OFF
    LCD_Cmd(0x06);  // Increment cursor - No shift
    LCD_Cmd(0x80);  // Address DDRAM with 0 offset 80h
}

void LCD_Cmd(unsigned char command) {
    LCD_Send(0,command);
}

void LCD_Char(unsigned char data) {
    LCD_Send(1,data);
}

void LCD_Send(int RS,unsigned char data)
{
    
    LCD_RS = RS;     // Data mode data = 1101, 1001
    LCD_DATA_PORT = (LCD_DATA_PORT & 0x0F) | (data & 0xF0);   // Send higher nibble 1101,0000
    
    LCD_EN = 1;     // Enable pulse
    __delay_us(1);
    LCD_EN = 0;
    __delay_us(200);
    LCD_DATA_PORT = (LCD_DATA_PORT & 0x0F) | ((data << 4) & 0xF0);   // Send lower nibble 1001,0000
    
    LCD_EN = 1;     // Enable pulse
    __delay_us(1);
    LCD_EN = 0;
    __delay_ms(2);

}

void LCD_String(const char* text) {
    while (*text != '\0') {
        LCD_Char(*text++);
    }
}

void LCD_Clear() {
    LCD_Cmd(0x01);  // Clear display
    __delay_ms(2);
}

void lcd_set_cursor(char col,char line)
{
    if(line==1){
        LCD_Cmd(0b10000000 | col);        
    }
    else if(line==2){
        LCD_Cmd(0b11000000 | col);        
    }
}
