
// PIC16F18877 Configuration Bit Settings

// 2023-07-16 19:50
/*
#pragma config FEXTOSC = XT
#pragma config WDTE = OFF
#pragma config LVP = OFF
#define _XTAL_FREQ 4000000
 */
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
#define LCD_RS PORTCbits.RC0 //RS
#define LCD_EN PORTEbits.RE0 //Enable
#define LCD_D4 PORTCbits.RC4 //Data 4 bit mode
#define LCD_D5 PORTCbits.RC5
#define LCD_D6 PORTCbits.RC6
#define LCD_D7 PORTCbits.RC7
#define LCD_DATA_PORT PORTC
// User Input with buttons
#define BUTTON_A PORTAbits.RA0;
#define BUTTON_A PORTAbits.RA1;
#define BUTTON_A PORTAbits.RA2;
#define BUTTON_A PORTAbits.RA5;
// Analog input
#define ANALOG_INPUT PORTAbits.RA3;

// Seven-segment display connections (example)
#define SEGMENT_A PORTBbits.RB0
#define SEGMENT_B PORTBbits.RB1
#define SEGMENT_C PORTBbits.RB2
#define SEGMENT_D PORTBbits.RB3
#define SEGMENT_E PORTBbits.RB4
#define SEGMENT_F PORTBbits.RB5
#define SEGMENT_G PORTBbits.RB6
#define _XTAL_FREQ 4000000

// Function prototypes
void LCD_Init();
void LCD_Cmd(unsigned char);
void LCD_Char(unsigned char);
void LCD_String(const char*);
void LCD_Clear();
void Display_Oxygen_Level(uint16_t);
void Display_Time(uint16_t);
void Display_Temperature(uint16_t);
uint16_t ADC_Read(uint8_t channel);

// Global variables
volatile uint16_t oxygenLevel = 0;
volatile uint16_t timerCount = 0;
volatile uint16_t temperature = 0;


void main(void) {
    // Initialize LCD and other modules
    LCD_Init();    
    ADCON0bits.ADON = 1;    // Enable ADC module
    TMR1 = 0;   // Clear Timer1 register
    T1CONbits.TMR1ON = 1;   // Start Timer1

    while (1) {
        // Read oxygen level from potentiometer
        oxygenLevel = ADC_Read(3);

        // Read temperature from temperature sensor
        temperature = ADC_Read(2);

        // Display oxygen level on LCD
        LCD_Clear();
        LCD_String("Oxygen Level:");
        LCD_Cmd(0xC0);  // Move cursor to the second line
        Display_Oxygen_Level(oxygenLevel);

        // Convert 13 seconds to 24 hours and display on seven-segment display
        Display_Time(13);   

        __delay_ms(500);    // Delay between consecutive readings
    }

    return;
}

void LCD_Init() {
    // Configure LCD pins as output
    TRISEbits.TRISE0 = 0;
    TRISCbits.TRISC0 = 0;
    TRISCbits.TRISC1 = 0;
    TRISCbits.TRISC4 = 0;
    TRISCbits.TRISC5 = 0;
    TRISCbits.TRISC6 = 0;
    TRISCbits.TRISC7 = 0;

    __delay_ms(15);

    LCD_Cmd(0x02);  // Return home
    LCD_Cmd(0x28);  // 4-bit mode - 2 line display - 5x7 font
    LCD_Cmd(0x0C);  // Display ON - Cursor OFF - Blink OFF
    LCD_Cmd(0x06);  // Increment cursor - No shift
    LCD_Cmd(0x80);  // Address DDRAM with 0 offset 80h
}

void LCD_Cmd(unsigned char command) {
    LCD_RS = 0;     // Command mode
    LCD_DATA_PORT = (LCD_DATA_PORT & 0x0F) | (command & 0xF0);   // Send higher nibble
    LCD_EN = 1;     // Enable pulse
    __delay_us(1);
    LCD_EN = 0;
    __delay_us(200);
    LCD_DATA_PORT = (LCD_DATA_PORT & 0x0F) | ((command << 4) & 0xF0);   // Send lower nibble
    LCD_EN = 1;     // Enable pulse
    __delay_us(1);
    LCD_EN = 0;
    __delay_ms(2);
}

void LCD_Char(unsigned char data) {
    LCD_RS = 1;     // Data mode
    LCD_DATA_PORT = (LCD_DATA_PORT & 0x0F) | (data & 0xF0);   // Send higher nibble
    LCD_EN = 1;     // Enable pulse
    __delay_us(1);
    LCD_EN = 0;
    __delay_us(200);
    LCD_DATA_PORT = (LCD_DATA_PORT & 0x0F) | ((data << 4) & 0xF0);   // Send lower nibble
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

void Display_Oxygen_Level(uint16_t level) {
    char buffer[5];
    sprintf(buffer, "%3u%%", level);
    LCD_String(buffer);
}

void Display_Time(uint16_t seconds) {
    uint16_t hours = seconds / 3600;
    uint16_t minutes = (seconds % 3600) / 60;
    seconds = seconds % 60;

    // Display hours on seven-segment display (example)
    SEGMENT_A = hours % 10;
    SEGMENT_B = (hours / 10) % 10;
    SEGMENT_C = (hours / 100) % 10;
    SEGMENT_D = (hours / 1000) % 10;
    // ...

    // Display minutes on seven-segment display (example)
    SEGMENT_E = minutes % 10;
    SEGMENT_F = (minutes / 10) % 10;
    // ...

    // Display seconds on seven-segment display (example)
    SEGMENT_G = seconds % 10;
    // ...
}

void Display_Temperature(uint16_t temp) {
    char buffer[6];
    float temperature = (float)temp * 0.48876 - 50.0; // Example conversion formula
    sprintf(buffer, "%.2fC", temperature);
    LCD_String(buffer);
}

uint16_t ADC_Read(uint8_t channel) {
    //ADCON0bits.CHS = channel;    // Select ADC channel    
    ADCON0bits.ADGO = 1;    // Start ADC conversion
 // Wait for ADC conversion to complete
    while (ADCON0bits.ADGO)
        ;

    // Return the ADC result
    return ((ADRESH << 8) + ADRESL);
}

