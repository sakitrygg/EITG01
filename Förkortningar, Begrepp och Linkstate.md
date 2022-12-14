# **Förkortningar, Begrepp och Linkstate**
### *Dator- och telekommunikation (EITG01)*
# **Innehåll**
- 1.0 Förkortningar med dess betydelse.     
- 2.0 Ord med dess betydelse.      
- 3.0 Link-State Algorithms.    
    - 3.1 Dijkstra´s algoritm   
#

## 1.0 Förkortningar
<br>

- **AS  - Autonomous System**   
Ett nätverk som administreras av ett företag, universitet eller liknande. Kan även kallas domän.

- **ATM - Asynchronous Transfer Mode**  
En förbindelseorienterad teknik

- **BGP - Border Gateway Protocol**  
Används för unicast inter-domän vägval.

- **BGMP - Border Gateway Multicast Protocol**   
Används för multicast inter-domän vägval.

- **CBT - Core-Based Trees**  
Vägvalsalgoritm.

- **CIDR - Classless Inter-Domain Routing**  
Klasslös vägvals adressering.

- **D -  Downstream**   
Väljare som tar emot data.

- **DVMRP - Distance Vector Multicast Routing Protocol**    
Ett vägvalsprotokoll för intra-domän multicast.

- **FEC - Forwarding Equivalence Class**    
Identifierar paket för att de ska skickas på samma sätt.

- **ICMP - Internet Control Message Protocol**  
Protokoll som hanterar kontrollmeddelanden.

- **IETF - Internet Engineering Task Force**    
Utför standardiseringsarbete för Internet.

- **IGMP - Internet Group Management Protocol**     
Protokoll som hanterar gruppmedlemskap.

- **IGP - Interior Gateway Protocol**   
Används för unicast intra-domän vägval.

- **IP - Internet Protocol**    
Protokoll för trafik över Internet.

- **IS-IS - Intermediate System to Intermediate System**    
Ett vägvalsprotokoll för intra-domän unicast.

- **LAN - Local Area Network**  
Ett lokalt nätverk.

- **LDP - Label Distribution Protocol**     
Ett protokoll som distribuerar etiketter.

- **LSP - Label Switched Path**     
Etikettväxlingsväg.

- **LSR - Label Switching Router**  
Etikettväxlingsväljare.

- **MBGP - Multiprotocol BGP**  
Utökad variant av BGP som medger distribution av multicastvägar.

- **MBONE - Multicast Backbone**    
Multicaststamnät.

- **MIP - Multicast Internet Protokoll**    
Ett vägvalsprotokoll för intra-domän multicast.

- **MOSPF - Multicast OSPF**    
Ett vägvalsprotokoll för intra-domän multicast.

- **MPLS - Multi-Protocol Label Switching**     
Ett protokoll som samverkar med skikt två och tre.

- **MSDP - Multicast Source Discovery Protocol**    
Ett protokoll som distribuerar information om aktiva källor.

- **OSI - Open System Interconnection**     
Rekommendation i sju skikt för datautbyte mellan olika datorsystem.

- **OSPF -  Open Shortest Path First**  
Ett vägvalsprotokoll för intra-domän unicast.

- **PIM-DM - Protocol Independent Multicast-Dense Mode**    
Ett vägvalsprotokoll för intra-domän multicast.

- **PIM-SM - Protocol Independent Multicast-Sparse Mode**   
Ett vägvalsprotokoll för intra-domän multicast.

- **PPP - Point to Point Protocol**     
Länkprotokoll för väljare. Internet protokoll.

- **RIP - Routing Information Protocol**    
Ett vägvalsprotokoll för intra-domän unicast.

- **RP - Rendezvous Point**     
Mötespunkt för sändare och mottagare.

- **RPB - Reverse Path Broadcasting**   
Vägvalsalgoritm

- **TRPB - Truncated Reverse Path Broadcasting**    
Vägvalsalgoritm

- **RPM - Reverse Path Multicasting**   
Vägvalsalgoritm

- **SM - Simple Multicast**     
Ett vägvalsprotokoll för intra-domän multicast.

- **TTL - Time To Live**    
Livstid för ett paket.

- **U -  Upstream**     
Väljare som sänder data.

- **UL - Unused Label**     
Oanvänd etikett.

- **VPI/VCI - Virtual Path Identifier/Virtual Circuit Identifier**  
En etikett som används i ATM-nät för att identifiera vägar och kanaler.

- **VPN - Virtual Private Network** 
Virtuellt privat nät

<br>

## 2.0 Ordlista
<br>

**Broadcast** - En sänder och alla mottager data.   

**Förbindelseorienterat** - En fast förbindelse existerar.

**Kärna** - eng. core, inre del av någonting.

**Multicast** - En eller flera sänder data till medlemmar i grupper.

**Multicaststamnät** - eng. multicast backbone, ett nät där man kan sända och ta emot multicastpaket.

**Kapa av** - eng. prune, att ansa, trimma, ta bort grenar i ett träd.

**Unicast** - En sänder och en mottager data.

**Vägval** - eng. routing, att dirigera data i ett nätverk.

**Väljare** - eng. router, dator som väljer väg för att vidarebefordra data i ett nätverk.

**Växel** - eng. switch, skikt-två-tekniken i OSI-modellen.
<br>
#

<br>
<br>



# 3.0 Link-State Algorithms
<br>

## 3.1 Dijkstra´s algoritm
- Nättopologi, länkkostnader kända för alla noder
    - Sker via "link-state broadcast". 
    - Alla noder har samma information.
- Beräkning av vägar med lägsta kostnad från en nod ("källa") till alla andra noder 
    - ger en ***vidarebefordringstabell*** för den noden
- Iterativ: efter k iterationer, vet minsta kostnaden för vägen till k destinationer

## Notation:
- $c(x,y)$: länkkostnad från noden. $x$ till $y; = ∞$ om inte direkt grannar
- $D(v)$: aktuellt värde för kostnaden för vägen från källan till destination v
- $p(v)$: föregångskod. längs vägen från källan till v
- $N'$: uppsättning av noder vars väg med lägsta kostnad slutgiltigt känd
#
## Dijkstra´s algoritm: exempel 

![](Bilder/Dijkstras.png)
#
## Dijkstra´s algoritm: annat exempel 

![](Bilder/Dijkstras2.png)
#
## Dijkstra´s algoritm: exempel 2

![](Bilder/Dijkstras3.png)
#
## Dijkstra´s algoritm, diskusion

![](Bilder/Dijkstras4.png)
