# **Protokoll och hur de fungerar**
### Dator- och telekommunikation (EITG01)

<br>

## PPP: Point-to-Point Protocol
#
&nbsp;  &nbsp;  &nbsp;  &nbsp;  &nbsp; **Field Name &nbsp; &nbsp; &nbsp; &nbsp; Size (bytes)  &nbsp; &nbsp; &nbsp; &nbsp; Description**
#
- **Flag  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 1 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;	
Flag:** Anger att en PPP-ram börjar. Har alltid värdet "01111110" binärt (0x7E hexadecimalt   
 &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp; &nbsp; eller 126 decimalt).

<br>

- **Address &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;  1	&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Address:** I HDLC är detta adressen till ramens destination. Men i PPP  
&nbsp; &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp; &nbsp;  har vi att göra med en direktlänk mellan två enheter, så det här fältet har ingen  
&nbsp; &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp; &nbsp; verklig betydelse. betydelse. Det är därför alltid inställt på "1111111111"   
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; (0xFF eller 255 decimaltal), vilket motsvarar en broadcast (det betyder "alla stationer"). 

<br>

- **Control &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 1 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Control:** Det här fältet används i HDLC för olika kontrolländamål, men i PPP är det inställt   
 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; till "00000011" (3 decimaler).

<br>

- **Protocol &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; 2 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; Protocol:**  Identifierar protokollet för datagrammet som är inkapslat i ramens informationsfält.   
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;  Se nedan för mer information om protokollfältet.

<br>

- **Information &nbsp; &nbsp; &nbsp; &nbsp;Variable	&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; Information:** Noll eller fler bytes payload som innehåller antingen data eller kontrollinformation,      
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; beroende på ramtyp. För vanliga PPP-dataframar kapslas nätverks-/lagerdatagrammet in här.   
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;   För kontrollramar placeras kontrollinformationsfälten här i stället.   

<br>

- **Padding	 &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp; Variable &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; Padding:** I vissa fall kan ytterligare dummy-bytes läggas till för att fylla ut PPP-ramens storlek.

<br>

<br>

- **FCS &nbsp; &nbsp; &nbsp; &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp;  &nbsp; &nbsp; &nbsp; 2 (or 4)	&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Frame Check Sequence (FCS):** En kontrollsumma som beräknas över ramen för att ge ett    
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; grundläggande skydd mot överföringsfel. Detta är en CRC-kod som liknar den som används för     
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; andra felskyddssystem i protokoll på lager två, t.ex. den som används i Ethernet. Den kan vara    
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; antingen 16 eller 32 bitar stor (standard är 16 bitar).   
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; FCS beräknas över adress-, kontroll-, protokoll-, informations- och fyllnadsfälten.     
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
<br>  

- **Flag  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 1 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; Flag:** Anger slutet på en PPP-ram. Har alltid värdet "01111110" binärt (0x7E hexadecimalt  
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; eller 126 decimalt).

<br>

#

<br>

## Nedan beskrivs de olika fälten i en PPP-ram:
<br>

### Flaggfält 
>PPP-ramen liknar HDLC-ramen och börjar och slutar alltid med standard HDLC-flaggan. Det har alltid ett värde på 1 byte, dvs. 01111110 binärt värde.


### Adressfält 
>Adressfältet är i princip en sändningsadress. I denna anger alla 1:or helt enkelt att alla stationer är redo att ta emot en ram. Det har värdet 1 byte, dvs. 111111111111 binärt värde. PPP tillhandahåller eller tilldelar däremot inte individuella stationsadresser.


### Kontrollfält 
>Detta fält använder i princip formatet för U-frame, dvs. onumrerad ram i HDLC. I HDLC krävs kontrollfältet för olika ändamål, men i PPP är detta fält inställt på 1 byte, dvs. binärt värde 0000001111. Denna 1 byte används för en anslutningslös datalänk.


### Protokollfältet 
>Detta fält identifierar i princip datagrammets nätverksprotokoll. Det identifierar vanligtvis vilken typ av paket som finns i datafältet, dvs. exakt vad som transporteras i datafältet. Fältet består av 1 eller 2 byte och hjälper till att identifiera den PDU (Protocol Data Unit) som är inkapslad i PPP-ramen.


### Datafältet 
>Det innehåller vanligtvis datagrammet från det övre lagret. Nätverkslagrets datagram är särskilt inkapslat i detta fält för vanliga PPP-dataraster. Längden på detta fält är inte konstant utan varierar.

### FCS-fältet 
> Detta fält innehåller vanligtvis en kontrollsumma för att identifiera fel. Det kan vara antingen 16 eller 32 bitar stort. Det beräknas också över adress-, kontroll-, protokoll- och även informationsfält. Tecken läggs till i ramen för kontroll och hantering av fel.

