# Veri Yapýlarý ve Algoritmalar - Project 1
[Selection Sort Project](https://app.patika.dev/courses/veri-yapilari-ve-algoritmalar/insertion-sort-proje)

**Insertion Sort  [22, 27, 16, 2, 18, 6]**


[2, 27, 16, 22, 18, 6]  &rarr; Dizinin en küçük elemanýný bulup dizinin en baþýndaki eleman ile yerini deðiþtirdik. [n]

&darr;

[2 | 27, 16, 22, 18, 6]  &rarr; Dizinin en küçük elemaný belirlendi, diðer kalan elemanlar arasýnda en küçük elemaný aramaya baþlýyoruz. [n-1]

&darr; 

[2, 6 | 16, 22, 18, 27]  &rarr; kalanlar arasýndaki en küçük elemaný bulup dizinin 2. sýrasýndaki eleman ile yer deðiþtirdik. [n-2]

&darr; 

[2, 6, 16 | 22, 18, 27]  &rarr; kalanlar arasýndaki en küçük eleman zaten dizinin 3. sýrasýnda olduðu için yer deðiþimi yok. [n-3]

&darr; 

[2, 6, 16, 18 | 22, 27]  &rarr; kalanlar arasýndaki en küçük elemaný bulup dizinin 4. sýrasýndaki eleman ile yer deðiþtirdik. [n-4]

&darr; 

[2, 6, 16, 18, 22, 27]  &rarr; dizinin kalan son iki elemaný olmasý gerektiði sýrada olduðu için yer deðiþimi yok. [n-5]


## Big - O Notation
Dizinin eleman sayýsý n olsun. (n=6)
Her aþamada 1 elaman eksilterek arama yapýldýðý için iþlem sayýsý bir eksilecektir. 
Ýlk sýralama n iken, 2. de (n-1), 3. de (n-3) diye 1'e kadar gidecektir.

Formulasyon: 
$n + (n-1) + (n-2) + ..... + 1 = n.(n+1) / 2 = n^2$

Big - O notasyonu: $O(n^2)$

## Time Complexity
Dizi sýralandýktan sonra 18 dizinin yaklaþýk orta sýralarýnda yer alacaðý için
"Average Case" kapsamýna girer.

----------------------------------------------------------------------

 **[7, 3, 5, 8, 2, 9, 4, 15, 6] dizisinin Selection Sort'a göre ilk 4 adýmý:**

*Adým 1:* [2 | 3, 5, 8, 7, 9, 4, 15, 6] 

*Adým 2:* [2, 3 | 5, 8, 7, 9, 4, 15, 6] 

*Adým 3:* [2, 3, 4 | 8, 7, 9, 5, 15, 6] 

*Adým 4:* [2, 3, 4, 5 | 7, 9, 8, 15, 6] 


[Hazýrlayan: Betül Çelik Çetin](https://app.patika.dev/celikbet)
