# Ecommerce Project

- Code first yöntemi ile Ntier Katmanlı Mimari kullanılarak yazılacak.
- Başlanıçte 3 katmandan meydana gelecek.

	- Model: Model katmanı dal katmanında varlıkları temsil eden Entity'leri barındıran katmandır.
		- Base: Interface'den almış olduğu özellikleri bünyesine dahil eder.
		- Entities: Veritabanında olmasını istediğimiz tabloları temsil eder.
			- AppUser
			- AppUserRole
			- Category
			- Product
			- Supplier



		- Enums: tablolarda kullanılacak sabitleri temsil eder.
		- Interfaces: Bütün classlara öncülük edek özellikleri barındırır.

	- DAL (Data Access Layer): Veritabanına ulaşım katmanını temsil eder. Veritabanı ile ilgili nesnelerimiz, tasarım desenleri, Entity gibi varlıklar bu katman içerisinde kullanılmalıdır.
		- Context: Veritabanı nesnesini temsil eder.


	- BLL (Business Logic Layer): İş mantığı katmanı olarak kullanılacaktır. Kullanıcın talep ettiği işlemler ilk olarak bu katman tarafından karşılanacak. Repository ve Service bu katman içerisinde oluşturulacak.
		--Repositories
			--Abstracts
				--BaseAbstracts
					-IRepository: Bu interface bütün işlemlere öncülük edecek metotların kurallarını barındırmaktadır. (CRUD) Interface dışarıdan bir T alır.
		--Concretes
			--BaseConcrete
				--BaseRepository: IRepository'den miras alara eylemleri (metotları) somut hale dönüştüren class.. Dıaşrıdan bir T alır

	Yukarıdaki tanımlamalarda bulunan T tipleri Ayrı bir servis oluşturulacak. Bu kuralları bünyesine alır. Bu kurallara göre spesifik eylemleri gerçekleştirir. Örneğin CategoryService'de gerçekleştirildiği gibi. (Bknz. CategoryService)
			

	- UI (User Interface): Sunum katmanını temsil eder. 
		- MVC projesi bu katman içerisinde oluşturulacak. 
		- Console App
		- WebApi

    - Common (Ortak Katman): İlerleyen etaplarda projenin daha esnek olabilmesi için her bir katmanda ortak olarak kullanılacak işlemler/yapılar bu katmanda yer almaktadırlar.
		--ImageHelper: İeçrisinde bulunan static metot vasıtasıyla dıaşrıdan iletilen dosyanın bir görsel olup olmadığını kontrol edilmesini ardından bu görselin projeye dahil edilmesini gerçekleştirir.

