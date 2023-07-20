# Custom Sender Email Uygulaması

Bu basit konsol uygulaması, C# programlama dili ile e-posta gönderme işlemlerini gerçekleştirmektedir.

## Özellikler

- E-posta gönderenin kimlik doğrulama bilgileri kullanılarak e-posta gönderimi.
- E-posta gönderenin isim ve e-posta adresinin, farklı bir özel gönderici adı ve e-posta adresi ile gösterilmesi isteği.

## Gereksinimler

- .NET Core SDK 3.1 veya daha yeni sürüm

## Nasıl Kullanılır

1. Projeyi klonlayın veya indirin.
2. `Program.cs` dosyasında `senderEmail`, `senderPassword` ve `senderDisplayName` değişkenlerine kendi e-posta adresinizi, şifrenizi ve adınızı girin.
3. E-posta alıcısının e-posta adresini `receiverEmail` değişkenine girin.
4. E-posta başlık ve içeriğini `subject` ve `body` değişkenlerine girin.
5. Custom gönderici e-posta adresini `customSenderEmail` değişkenine girin. Not: SMTP protokolü ve e-posta sağlayıcıların davranışı nedeniyle, gerçek gönderici e-posta adresi, kimlik doğrulama bilgileriyle eşleşecektir. Bu nedenle, farklı bir gönderici e-posta adresi gösterme özelliği doğrudan sağlayıcı tarafından kısıtlanmıştır.
6. Uygulamayı çalıştırın.
7. Program size "Saniyede kaç e-posta göndermek istersiniz?" diye soracaktır. Saniyede kaç e-posta göndermek istediğinizi belirtin.
8. Uygulama, belirttiğiniz hızda e-postaları göndermeye başlayacak ve gönderi durumunu ekrana yazdıracaktır.

## Notlar

- E-posta gönderimi sırasında gerçek e-posta adresiniz ve şifreniz kullanılarak e-postalar gönderilecektir. SMTP sunucuları, kimlik doğrulama bilgilerine dayanarak gönderilen e-postaları yetkilendirmek için kullanılır ve bu nedenle gönderilen e-postaların "From" alanında belirtilen e-posta adresi, kimlik doğrulama bilgileriyle eşleşmelidir.
- E-posta gönderimi konusunda standart protokoller ve güvenlik önlemleri göz önünde bulundurulduğunda, gönderici e-posta adresini ve kimlik doğrulama bilgilerini değiştirmek, e-posta sağlayıcıların temel davranışı nedeniyle mümkün değildir.
- Bu uygulamayı kullanırken, e-posta sağlayıcınızın kullanım politikalarını ve izinlerini dikkate almanız önemlidir.

**Not:** E-posta gönderimi sırasında kullanılan e-posta adresi ve kimlik doğrulama bilgileri SMTP sunucusuna gönderildiğinden, SMTP sunucusu gönderici e-posta adresini gerçek e-posta adresi olarak gösterecektir. Bu nedenle, farklı bir gönderici e-posta adresi veya kimlik doğrulama bilgilerini gösterme özelliği, SMTP protokolünün temel davranışıyla uyumlu değildir ve mevcut e-posta sağlayıcılarının izin vermediği bir uygulamadır.

## Lisans

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Bu projeyi [MIT Lisansı](https://opensource.org/licenses/MIT) altında lisansladık. Lisansın tam açıklamasını burada bulabilirsiniz.

