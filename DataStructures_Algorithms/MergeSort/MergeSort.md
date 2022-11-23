# Data Structures & Algorithms - Project 2
## [MergeSort Project](https://app.patika.dev/courses/veri-yapilari-ve-algoritmalar/merge-sort-proje)

**Sorting: [16, 21, 11, 8, 12, 22]**


|16|21|11| 8|12|22|
|--|--|--|--|--|--| 

&darr; Diziyi tek elemanlý kalana kadar 2'ye bölüp ayrýþtýrýyoruz.

|16|21|11|------------| 8|12|22|
|--|--|--|------------|--|--|--| 

&darr;		 

|16|21|---------|11|---------| 8|12|---------|22|
|--|--|---------|--|---------|--|--|---------|--|


&darr;		 

|16|------|21|------|11|------| 8|------|12|------|22|
|--|------|--|------|--|------|--|------|--|------|--|

&darr;	kendi içerisinde sýralayarak mini diziler oluþturuyoruz.


|16|21|---------|11|---------| 8|12|---------|22|
|--|--|---------|--|---------|--|--|---------|--|

&darr;	

|11|16|21|------------| 8|12|22|
|--|--|--|------------|--|--|--|

&darr;	

| 8|11|12|16|21|22|
|--|--|--|--|--|--| 



**Big - O Notation:**

Diziyi her adýmda ikiye böldüðümüz için dizinin eleman sayýsýna n dersek, her adýmda n/2, n/4 þeklinde iþlem yükü olacak.

Formulasyon: $2^x = n > x = log_n$

Big-O notasyonu: $O(n.log_n)$

[Hazýrlayan: Betül Çelik Çetin](https://app.patika.dev/celikbet)