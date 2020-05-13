
# Singleton Tasarım Kalıbı
### Design pattern kullanmanın faydaları nelerdir ?
1.	Design patternda belirli 1 problem için belirli 1 çözüm vardır.</br>
2.	Tasarımı iyileştirir.</br>
3.	Takımın iletişimini artırır. Takımdaki herkesin aynı şeyi konuşup aynı şeyi anlamasını sağlar. Design patternın bir ismi vardır ve bir çözümü vardır, takım aynı dili konuşur.</br>

### Singleton Nedir? Hangi Durumlarda Kullanırız?
Singleton desgin pattern çalışma zamanında yalnızca 1 object yaratılmasını garanti eden tasarım desenidir.
</br>

**Kullanımına ihtiyaç duyulan durum şudur** :
1.	Birden çok sınıfın aynı instance’ı kullanması gerekmektedir.
2.	Tüm uygulama için yalnızca bir nesne olması gerekmektedir.
3.	Sadece bir nesne olduğu (unique) garanti edilmelidir.

Bu gereklilikler için bir sınıf yaratırız ve sınıfın kendi instance’ını yönetmesini sağlarız.
Önemli nokta : Bir sınıfın yalnızca bir instance’ının bulunduğundan emin olmalıyız ve buna global erişim noktası sağlamalıyız.
</br>

**Singleton pattern kullanmanın faydaları**:
1. Bir instance‘a kontrollü erişim sağlanır.
2.	Global değişkenler yaratmaktan kaçınırız.


 ### Singleton UML Diyagramı
![Singleton UML](https://www.tutorialspoint.com/design_pattern/images/singleton_pattern_uml_diagram.jpg)


 
