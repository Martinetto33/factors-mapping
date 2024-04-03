# FactorsMapping

Questo repository è stato creato per proporre una soluzione al quesito che mi è stato posto ad un colloquio.
In sintesi, si richiede di stampare i numeri da 1 a n, con n fornito come input, associando a ciascuno di questi numeri una stringa in caso siano divisibili per uno o più numeri. Si richiede anche di calcolare il costo computazionale della soluzione fornita.

## Strategia risolutiva
L'utente specifica una lista di coppie chiave-valore con chiavi di tipo intero (i fattori che dovranno essere mappati a delle stringhe particolari) e valori di tipo stringa.

Dato un numero *n* positivo e maggiore di 0 come input, si itera su tutti i numeri da *1* a *n* compresi. Per ciascuno di questi numeri *i*, si verifica se per caso questo sia divisibile per uno qualsiasi dei valori *k_j* presenti nella lista di mappature. Se sì, al posto di *i* si stampa la corrispondente stringa.

Se *k* è il numero totale di chiavi e *n* è il numero fornito in input, l'algoritmo ha un costo computazionale di **O(k * n)**, in quanto per *n* volte si itera potenzialmente su tutto lo spazio delle chiavi (quindi al massimo *k* passi).

La soluzione proposta consente di lavorare con molteplici mappature di fattori ed ha un costo lineare in *k * n*.

