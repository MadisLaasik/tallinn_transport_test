Valisin variant C alt lehekülje https://transport.tallinn.ee/. Programmiks võtsin Selenium Visual Studio ja programmeerimiskeeleks C#. Kuna varasem kokkupuude oli ainult Selenium IDE sammude salvestamisega ja nende tagasimängimisega, siis pidin värskelt õppima kasutama Visual Studio programmi. 
Visual Studios programmis on automatiseeritud järgmised testisammud:
Google Chrome kasutades liikuda https://transport.tallinn.ee/ leheküljele.
Aktiveerida "Troll" nimeline menüü valik.
Aktiveerida "5 Mustamäe-Balti jaam" menüü valik.
Aktiveerida "5 Balti jaam-Mustamäe" menüü valiku alt "Marja" peatus.
Aktiveerida "Näita kaarti" ja "Näita kõiki väljumisi peatusest" vahel olev kollane täheke, mis tähendab Balti jaam-Mustamäe Trolli Marja peatuse lisamist lemmikute valiku alla. Kahjuks ma inspect-ides seda tähekest ei leidnud vajalikke viiteid, mis aitaks mul seda sammu automaattestimisega teha. Seega kahjuks jäi mul lemmikute lisamise samm poolikuks.
Aktiveerida vasakul menüüribal tähekese kujund, et näha lõpuks seal all Balti jaam-Mustamäe trolli Marja peatuse järgmiseid väljumisi.
