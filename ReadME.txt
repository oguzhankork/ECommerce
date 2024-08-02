# Ecommerce Project

- Code first y�ntemi ile Ntier Katmanl� Mimari kullan�larak yaz�lacak.
- Ba�lan��te 3 katmandan meydana gelecek.

	- Model: Model katman� dal katman�nda varl�klar� temsil eden Entity'leri bar�nd�ran katmand�r.
		- Base: Interface'den alm�� oldu�u �zellikleri b�nyesine dahil eder.
		- Entities: Veritaban�nda olmas�n� istedi�imiz tablolar� temsil eder.
			- AppUser
			- AppUserRole
			- Category
			- Product
			- Supplier



		- Enums: tablolarda kullan�lacak sabitleri temsil eder.
		- Interfaces: B�t�n classlara �nc�l�k edek �zellikleri bar�nd�r�r.

	- DAL (Data Access Layer): Veritaban�na ula��m katman�n� temsil eder. Veritaban� ile ilgili nesnelerimiz, tasar�m desenleri, Entity gibi varl�klar bu katman i�erisinde kullan�lmal�d�r.
		- Context: Veritaban� nesnesini temsil eder.


	- BLL (Business Logic Layer): �� mant��� katman� olarak kullan�lacakt�r. Kullan�c�n talep etti�i i�lemler ilk olarak bu katman taraf�ndan kar��lanacak. Repository ve Service bu katman i�erisinde olu�turulacak.
		--Repositories
			--Abstracts
				--BaseAbstracts
					-IRepository: Bu interface b�t�n i�lemlere �nc�l�k edecek metotlar�n kurallar�n� bar�nd�rmaktad�r. (CRUD) Interface d��ar�dan bir T al�r.
		--Concretes
			--BaseConcrete
				--BaseRepository: IRepository'den miras alara eylemleri (metotlar�) somut hale d�n��t�ren class.. D�a�r�dan bir T al�r

	Yukar�daki tan�mlamalarda bulunan T tipleri Ayr� bir servis olu�turulacak. Bu kurallar� b�nyesine al�r. Bu kurallara g�re spesifik eylemleri ger�ekle�tirir. �rne�in CategoryService'de ger�ekle�tirildi�i gibi. (Bknz. CategoryService)
			

	- UI (User Interface): Sunum katman�n� temsil eder. 
		- MVC projesi bu katman i�erisinde olu�turulacak. 
		- Console App
		- WebApi

    - Common (Ortak Katman): �lerleyen etaplarda projenin daha esnek olabilmesi i�in her bir katmanda ortak olarak kullan�lacak i�lemler/yap�lar bu katmanda yer almaktad�rlar.
		--ImageHelper: �e�risinde bulunan static metot vas�tas�yla d�a�r�dan iletilen dosyan�n bir g�rsel olup olmad���n� kontrol edilmesini ard�ndan bu g�rselin projeye dahil edilmesini ger�ekle�tirir.


#SMTP Ayarlar�
Email: yzl3172@outlook.com
Pass: YzlKadikoy--