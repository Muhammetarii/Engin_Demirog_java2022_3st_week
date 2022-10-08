package javaApp;


public class Main {

	public static void main(String[] args) {	
		/*
		 * int number1 = 10; int number2 = 20; number1 = number2; number2 = 100; // int
		 * değer tip olup sadece değer ataması yapar.Örnekte verilen number1 değeri 10
		 * iken number2 nun sayı değeri olan 20 ye eşitlenir.
		 * 
		 * int[] numbers1 = { 1, 2, 3 }; int[] numbers2 = { 10, 20, 30 }; numbers1 =
		 * numbers2 ;//Bu ifadenin anlamı number1 in referans numarasının numbers2 nin
		 * referans numarasına eşitlemesidir. numbers2[0] = 1000;
		 * 
		 * System.out.println(numbers1[0]);// Array lar değer tip değil referans tiptir.
		 **/	
//		CreditManager creditManager = new CreditManager();// İşlemde = kadar olan kısımda belleğin stack kısmında tutulup,
//		creditManager.calculate();						 //new yapma işlemi ile belleğin  heap kısmında bir referans oluşuyor.
//		creditManager.calculate();
//		creditManager.save();	
//		
//		Customer customer = new Customer(); // new leme işlemi örneğini oluşturmak veya instance creation dır.
//		customer.id = 1;
//		customer.city = "Ankara";
//		
//		
//		CustomerManager customerManager = new CustomerManager(customer);
//		customerManager.save();
//		customerManager.delete();
//		
//		Company company = new Company();
//		company.taxNumber = "100000";
//		company.companyName = "Arçelik";
//		company.id =100;
//		
//		CustomerManager customerManager2 = new CustomerManager(new Person());//Inheritance
//		
//		Person person = new Person();
//		person.firstName = "Muhammet";
//		person.nationalIdentity = "123456789";
//		
//		Customer c1 = new Customer();
//		Customer c2 = new Person();
//		Customer c3 = new Company();
		
		CustomerManager customerManager = new CustomerManager(new Customer(), new MilitaryCreditManager());//IoC Container
		customerManager.giveCredit();
		
		
		
	
	}

}
