using COMPOSITE;


//CRIADO MENU ANDROID
Menu Android = new Menu("ANDROID");
Android.Adicionar(new Produto("SANSUNG S21", "https://www.americanas.com.br/busca/celular-moto-s21"));
Android.Adicionar(new Produto("MOTOROLA G52", "https://www.motorola.com.br/smartphone-moto-g52/p?gad=1&gclid=CjwKCAjwpuajBhBpEiwA_ZtfhU2hnBqg-efOAS72VUnyZEAtvnvrJIA2eTKbEyivfcYKpiEa7iRWLBoCMfYQAvD_BwE&idsku=1340"));


//CRIANDO MENU CELULARES
Menu menuCelulares = new Menu("CELULARES");
menuCelulares.Adicionar(new Produto("Iphone 14 Pro", "https://www.magazineluiza.com.br/iphone-14-pro/celulares-e-smartphones/s/te/i14p/"));
menuCelulares.Adicionar(new Produto("Iphone 14 Pro Max", "https://www.magazineluiza.com.br/iphone-14-pro-max/celulares-e-smartphones/s/te/14pm/"));

//ADICIONANDO SUB MENU CELULARES ANDROID
menuCelulares.Adicionar(Android);


//CRIANDO MENU MOVEIS
Menu menuMoveis = new Menu("MÓVEIS");
menuMoveis.Adicionar(new Produto("Guarda Roupas", "https://www.magazineluiza.com.br/guarda-roupa-roupeiro/moveis/s/mo/guro/"));
menuMoveis.Adicionar(new Produto("Rack", "https://www.magazineluiza.com.br/rack/moveis/s/mo/racm/"));


//CRIANDO MENU PRINCIPAL
Menu menuPricipal = new Menu("***MENU***");


//CRIANDO SUBMENU CELULARES
menuPricipal.Adicionar(menuCelulares);
//CRIANDO SUBMENU MOVEIS
menuPricipal.Adicionar(menuMoveis);



// APRESENTAR O MENU COMPLETO
menuPricipal.Mostrar();
