# Encrypt-File-with-3DES
Q�llimi i projektit
Krijimi i programit q� mund�son enkriptimin me 3DES t� nj� fajlli, t� cilin ne mund t�a zgjedhim. Programi t� mund�soj shkruarjen e celsit enkriptues dhe gjithashtu ket� si alternativ� gjenerimin automatik t� celsit enkriptues. Ky program duhet t� b�j leximin brenda file-it, t� enkriptoj dhe t� ruaj celsin enkriptues n� m�nyr� q� faili i enkriptuar pas nj� koh� (Stop runnning ? Start) t� mund t� dekriptohet me at� cel�s!

Koncepte t� p�rgjithshme p�r (3)DES-in
Triple Data Encryption Algorithm 3DES i cili pastaj b�n� Data Encryption Standard (DES) tri her� n� secilin bllok me t� dh�na. Algoritmi DES p�rdor� celsin me gjat�si 56 bitesh, tanim� nuk �sht� shum� i sigurt� sepse me kompjuter t� fuqish�m ai mund t� thyhet me bruteforce dhe p�r t�i ikur k�tij rreziku 3DES-i p�rdor celsin 3*56=168 bit (mund t� p�rdor� cels edhe me 115 bit). Celsat mund t� jen�:
1. Celsat t� pavarur Key1 ? Key2 ? Key3 (q� e b�n� t� pamundur BruteForce-in).
2. Key1 dhe Key2 jan� t� pavarur, nd�rsa Key3 = Key1. (cel�s 112bitsh)
3. T� tre celsat jan� t� njejt� Key1 = Key2 = Key3 (�sht� njejt� sikur DES-i, 56bit).

Algoritmi
Teksti i enkriptuar (ciphertext) �sht� rezultat i p�rb�r� nga:
1. Enkriptimi t� tekstit (plaintext) me celsin Key1
2. Dekriptimi i tekstit me celsin Key2 i asaj q� fitohet pas pik�s t� lart� p�rmendur 1.
3. Enkriptimi i tekstit q� fitohet nga pika e lart� p�rmendur 2.
ciphertext = EKey3(DKey2(EKey1(plaintext)))
Dekriptimi �sht� i anasjellt�:
plaintext = DKey1(EKey2(DKey3(ciphertext)))
Modi enkriptues i cili �sht� p�rdorur n� k�t� projekt �sht� CBC, ky mod �sht� m� i sigurt� pasiq� n� bllokun e par� p�rdor IV (vektorin inicializues) dhe hyrja e bllokut tjet�r p�rdor� daljen e bllokut paraprak.

P�rdorimi i 3DES-it
3DES-i gjen� p�rdorim n� industrit e pagesave elektronike, n� Microsoft OneNote,
Microsoft Outlook 2007, Microsoft System Center Configuration Manager 2012 p�rdor�
Triple DES p�r mbrojtjen password-it t� user-ave dhe t� dh�nat e sistemit.