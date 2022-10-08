package javaApp;


public class CustomerManager {
	
	private Customer customerManager;
	private ICreditManager _creditManager;
	
	public CustomerManager(Customer customer,ICreditManager creditManager) {
		set_creditManager(creditManager);
		}
		
	public void save() {
		
		System.out.println("Müşteri kaydedildi : ");
		
	}
	
	public void delete() {
		
		System.out.println("Müşteri silindi : ");
		
	}
	
	public void giveCredit() {
		_creditManager.calculate();
		System.out.println("Kredi verildi");
		
		
	}

	public ICreditManager get_creditManager() {
		return _creditManager;
	}

	public void set_creditManager(ICreditManager _creditManager) {
		this._creditManager = _creditManager;
	}

	public Customer getCustomerManager() {
		return customerManager;
	}

	public void setCustomerManager(Customer customerManager) {
		this.customerManager = customerManager;
	}
	
	

}
