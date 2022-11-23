# Data Structures & Algorithms - Project 2
## [MergeSort Project](https://app.patika.dev/courses/veri-yapilari-ve-algoritmalar/merge-sort-proje)

**Sorting: [16, 21, 11, 8, 12, 22]**


|16|21|11| 8|12|22|
|--|--|--|--|--|--| 

&darr; Diziyi tek elemanl� kalana kadar 2'ye b�l�p ayr��t�r�yoruz.

|16|21|11|------------| 8|12|22|
|--|--|--|------------|--|--|--| 

&darr;		 

|16|21|---------|11|---------| 8|12|---------|22|
|--|--|---------|--|---------|--|--|---------|--|


&darr;		 

|16|------|21|------|11|------| 8|------|12|------|22|
|--|------|--|------|--|------|--|------|--|------|--|

&darr;	kendi i�erisinde s�ralayarak mini diziler olu�turuyoruz.


|16|21|---------|11|---------| 8|12|---------|22|
|--|--|---------|--|---------|--|--|---------|--|

&darr;	

|11|16|21|------------| 8|12|22|
|--|--|--|------------|--|--|--|

&darr;	

| 8|11|12|16|21|22|
|--|--|--|--|--|--| 



**Big - O Notation:**

Diziyi her ad�mda ikiye b�ld���m�z i�in dizinin eleman say�s�na n dersek, her ad�mda n/2, n/4 �eklinde i�lem y�k� olacak.

Formulasyon: $2^x = n > x = log_n$

Big-O notasyonu: $O(n.log_n)$

[Haz�rlayan: Bet�l �elik �etin](https://app.patika.dev/celikbet)