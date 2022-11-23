# Veri Yap�lar� ve Algoritmalar - Project 1
[Selection Sort Project](https://app.patika.dev/courses/veri-yapilari-ve-algoritmalar/insertion-sort-proje)

**Insertion Sort  [22, 27, 16, 2, 18, 6]**


[2, 27, 16, 22, 18, 6]  &rarr; Dizinin en k���k eleman�n� bulup dizinin en ba��ndaki eleman ile yerini de�i�tirdik. [n]

&darr;

[2 | 27, 16, 22, 18, 6]  &rarr; Dizinin en k���k eleman� belirlendi, di�er kalan elemanlar aras�nda en k���k eleman� aramaya ba�l�yoruz. [n-1]

&darr; 

[2, 6 | 16, 22, 18, 27]  &rarr; kalanlar aras�ndaki en k���k eleman� bulup dizinin 2. s�ras�ndaki eleman ile yer de�i�tirdik. [n-2]

&darr; 

[2, 6, 16 | 22, 18, 27]  &rarr; kalanlar aras�ndaki en k���k eleman zaten dizinin 3. s�ras�nda oldu�u i�in yer de�i�imi yok. [n-3]

&darr; 

[2, 6, 16, 18 | 22, 27]  &rarr; kalanlar aras�ndaki en k���k eleman� bulup dizinin 4. s�ras�ndaki eleman ile yer de�i�tirdik. [n-4]

&darr; 

[2, 6, 16, 18, 22, 27]  &rarr; dizinin kalan son iki eleman� olmas� gerekti�i s�rada oldu�u i�in yer de�i�imi yok. [n-5]


## Big - O Notation
Dizinin eleman say�s� n olsun. (n=6)
Her a�amada 1 elaman eksilterek arama yap�ld��� i�in i�lem say�s� bir eksilecektir. 
�lk s�ralama n iken, 2. de (n-1), 3. de (n-3) diye 1'e kadar gidecektir.

Formulasyon: 
$n + (n-1) + (n-2) + ..... + 1 = n.(n+1) / 2 = n^2$

Big - O notasyonu: $O(n^2)$

## Time Complexity
Dizi s�raland�ktan sonra 18 dizinin yakla��k orta s�ralar�nda yer alaca�� i�in
"Average Case" kapsam�na girer.

----------------------------------------------------------------------

 **[7, 3, 5, 8, 2, 9, 4, 15, 6] dizisinin Selection Sort'a g�re ilk 4 ad�m�:**

*Ad�m 1:* [2 | 3, 5, 8, 7, 9, 4, 15, 6] 

*Ad�m 2:* [2, 3 | 5, 8, 7, 9, 4, 15, 6] 

*Ad�m 3:* [2, 3, 4 | 8, 7, 9, 5, 15, 6] 

*Ad�m 4:* [2, 3, 4, 5 | 7, 9, 8, 15, 6] 


[Haz�rlayan: Bet�l �elik �etin](https://app.patika.dev/celikbet)
