Qellimi i projektit
Krijimi i programit qe mundeson enkriptimin me 3DES te nje fajlli, te cilin ne mund t’a zgjedhim. Programi te mundesoj shkruarjen e celsit enkriptues dhe gjithashtu kete si alternative gjenerimin automatik te celsit enkriptues. Ky program duhet te bej leximin brenda file-it, te enkriptoj dhe te ruaj celsin enkriptues ne menyre qe faili i enkriptuar pas nje kohe (Stop runnning Start) te mund te dekriptohet me ate celes!

Koncepte te pergjithshme per (3)DES-in
Triple Data Encryption Algorithm 3DES i cili pastaj bene Data Encryption Standard (DES) tri here ne secilin bllok me te dhena. Algoritmi DES perdore celsin me gjatesi 56 bitesh, tanime nuk eshte shume i sigurte sepse me kompjuter te fuqishem ai mund te thyhet me bruteforce dhe per t’i ikur ketij rreziku 3DES-i perdor celsin 3*56=168 bit (mund te perdore cels edhe me 115 bit). Celsat mund te jene:
1. Celsat te pavarur (qe e bene te pamundur BruteForce-in).
2. Key1 dhe Key2 jane te pavarur, ndersa Key3 = Key1. (celes 112bitsh)
3. Te tre celsat jane te njejte Key1 = Key2 = Key3 (eshte njejte sikur DES-i, 56bit).
Algoritmi
Teksti i enkriptuar (ciphertext) eshte rezultat i perbere nga:
1. Enkriptimi te tekstit (plaintext) me celsin Key1
2. Dekriptimi i tekstit me celsin Key2 i asaj qe fitohet pas pikes te larte permendur 1.
3. Enkriptimi i tekstit qe fitohet nga pika e larte permendur 2.