# Encrypt-File-with-3DES
Qëllimi i projektit
Krijimi i programit që mundëson enkriptimin me 3DES të një fajlli, të cilin ne mund t’a zgjedhim. Programi të mundësoj shkruarjen e celsit enkriptues dhe gjithashtu ketë si alternativë gjenerimin automatik të celsit enkriptues. Ky program duhet të bëj leximin brenda file-it, të enkriptoj dhe të ruaj celsin enkriptues në mënyrë që faili i enkriptuar pas një kohe (Stop runnning and then Start) të mund të dekriptohet me atë celës!

Koncepte të përgjithshme për (3)DES-in
Triple Data Encryption Algorithm 3DES i cili pastaj bënë Data Encryption Standard (DES) tri herë në secilin bllok me të dhëna. Algoritmi DES përdorë celsin me gjatësi 56 bitesh, tanimë nuk është shumë i sigurtë sepse me kompjuter të fuqishëm ai mund të thyhet me bruteforce dhe për t’i ikur këtij rreziku 3DES-i përdor celsin 3*56=168 bit (mund të përdorë cels edhe me 115 bit). Celsat mund të jenë:
1. Celsat të pavarur Key1 ? Key2 ? Key3 (që e bënë të pamundur BruteForce-in).
2. Key1 dhe Key2 janë të pavarur, ndërsa Key3 = Key1. (celës 112bitsh)
3. Të tre celsat janë të njejtë Key1 = Key2 = Key3 (është njejtë sikur DES-i, 56bit).

Algoritmi
Teksti i enkriptuar (ciphertext) është rezultat i përbërë nga:
1. Enkriptimi të tekstit (plaintext) me celsin Key1
2. Dekriptimi i tekstit me celsin Key2 i asaj që fitohet pas pikës të lartë përmendur 1.
3. Enkriptimi i tekstit që fitohet nga pika e lartë përmendur 2.
ciphertext = EKey3(DKey2(EKey1(plaintext)))
Dekriptimi është i anasjelltë:
plaintext = DKey1(EKey2(DKey3(ciphertext)))
Modi enkriptues i cili është përdorur në këtë projekt është CBC, ky mod është më i sigurtë pasiqë në bllokun e parë përdor IV (vektorin inicializues) dhe hyrja e bllokut tjetër përdorë daljen e bllokut paraprak.

Përdorimi i 3DES-it
3DES-i gjenë përdorim në industrit e pagesave elektronike, në Microsoft OneNote,
Microsoft Outlook 2007, Microsoft System Center Configuration Manager 2012 përdorë
Triple DES për mbrojtjen password-it të user-ave dhe të dhënat e sistemit.
