
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

#define LCD_DATA_D7         PORTCbits.RC7
#define LCD_DATA_D6         PORTCbits.RC6
#define LCD_DATA_D5         PORTCbits.RC5
#define LCD_DATA_D4         PORTCbits.RC4
#define LCD_RS              PORTCbits.RC0 	
#define LCD_E               PORTCbits.RC3
#define _XTAL_FREQ 4000000

unsigned int adc_GetConversion(void);

void lcdWriteCtrlWord(char x);
void lcdWriteDspData(char x);
void lcdWriteNibble(char nibble); 
void lcdCtrl_SetPos(unsigned char row, unsigned char col);
void lcdCtrl_FunctionSet(void);
void lcdCtrl_OnOffDisplay(char display_state, char cursor_state);
void lcdCtrl_SetEntryMode(void);
void lcdCtrl_ClearDisplay(void);
void initLCD(void);
void oxygen_medium();

unsigned int get_count(void);

int main()
{
    initLCD();
    lcdCtrl_SetPos(1,1);
    oxygen_medium();
    
    return 0;
}

void initLCD(void)                      
{		

    TRISC = 0x00;
    __delay_ms(15);         	   
    lcdWriteCtrlWord(0b00000011);  
    __delay_ms(5);		   
    lcdWriteCtrlWord(0b00000010);    
	
    lcdCtrl_FunctionSet(); 	   
    lcdCtrl_OnOffDisplay(1, 0);    
    lcdCtrl_SetEntryMode();	   
    lcdCtrl_ClearDisplay();	   
}
void lcdWriteCtrlWord(char x) 
{     
    unsigned char upper_nibble, lower_nibble;
    
    upper_nibble = (x & 0b11110000) >> 4;
    lower_nibble = x & 0b00001111;
    
    LCD_RS = 0;
    lcdWriteNibble(upper_nibble);
    lcdWriteNibble(lower_nibble);
}

void lcdWriteDspData(char x) 
{     
    unsigned char upper_nibble, lower_nibble;
    
    upper_nibble = (x & 0b11110000) >> 4;
    lower_nibble = x & 0b00001111;
    
    LCD_RS = 1;
    lcdWriteNibble(upper_nibble);
    lcdWriteNibble(lower_nibble);
}
void lcdWriteNibble(char nibble) 
{
    LCD_DATA_D7 = (nibble & 0b00001000) >> 3;
    LCD_DATA_D6 = (nibble & 0b00000100) >> 2;
    LCD_DATA_D5 = (nibble & 0b00000010) >> 1;
    LCD_DATA_D4 = (nibble & 0b00000001);
    
    LCD_E       = 1;
    __delay_ms(1);
    LCD_E       = 0;
    __delay_ms(1);    
}


void lcdCtrl_SetPos(unsigned char row, unsigned char col) 
{
    unsigned char ramAddr;        

    if (row == 1)                 
        ramAddr = col - 1;        
    else                         
        ramAddr = 0x40 + col - 1; 
    lcdWriteCtrlWord(0x80 + ramAddr); 
}

void lcdCtrl_FunctionSet(void) 
{
    lcdWriteCtrlWord(0b00101000);
}

void lcdCtrl_OnOffDisplay(char display_state, char cursor_state) 
{
    char pattern = 0b00001000;

    if(display_state == 1)
        pattern |= 0b00000100;    
    if(cursor_state == 1)
        pattern |= 0b00000011;
    
    lcdWriteCtrlWord(pattern);
}

void lcdCtrl_SetEntryMode(void) 
{
    lcdWriteCtrlWord(0b000001100);    
}

void lcdCtrl_ClearDisplay(void) 
{
    lcdWriteCtrlWord(0b00000001);    
}
void oxygen_low(void){
 char message1[] ="oxygen lvl low";
unsigned int i;
lcdWriteCtrlWord(0b000001100); 
lcdWriteCtrlWord(0b00000001); 
    lcdCtrl_SetPos(1, 1);
for(i = 0; message1[i]!=0; i++) {
lcdWriteDspData(message1[i]);
}
}

void oxygen_medium(void){

char message2[] =" oxygen lvl medium";
unsigned int i;
lcdWriteCtrlWord(0b000001100); 
lcdWriteCtrlWord(0b00000001);
lcdCtrl_SetPos(1, 1);
for(i = 0; message2[i]!=0; i++) {
lcdWriteDspData(message2[i]);
}
}
void oxygen_high(void){
char message3[] ="oxygen lvl high";
unsigned int i;
lcdWriteCtrlWord(0b000001100); 
lcdWriteCtrlWord(0b00000001);
lcdCtrl_SetPos(1, 1);
for(i = 0; message3[i]!=0; i++) {
lcdWriteDspData(message3[i]);
    
}
}
