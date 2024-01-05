using Cell.Models;

Smartphone nokia = new Nokia("123456789", "Nokia", "123456789", 300);
nokia.InstalarAplicativo("Face");
nokia.InstalarAplicativo("Whats");
nokia.InstalarAplicativo("Teleg");
nokia.ApresentacaoSmartphone();
nokia.ExibirListaDeApps();


Smartphone iphone = new Iphone("123123123", "Iphone", "123123123", 200);
iphone.InstalarAplicativo("Face");
iphone.InstalarAplicativo("Whats");
iphone.InstalarAplicativo("Teleg");
iphone.ApresentacaoSmartphone();
iphone.ExibirListaDeApps();