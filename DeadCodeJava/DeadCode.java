// Find methods that are declared, but not called.
// FindByType(CxDOMType)
// FindDefinition(CxList)

class TV
{
	int channel = -1;
	boolean power = false;
	int volume = 0;
	String input = "HDMI0";
	
	public TV() {
		System.out.println("Initializing a new TV");
	} //end constructor
	
	void changeChannel(int c) {
		this.channel = c;
		System.out.println("Channel set to " + this.channel);
	} //end changeChannel
	
	void togglePower() {
		this.power = !power;
		System.out.println("Power is " + (this.power ? "on" : "off"));
	} //end togglePower
	
	void changeVolume(int change) {
		this.volume += change;
		System.out.print("Volume changed to " + this.volume);	
	} //end changeVolume
	
	void switchInput(String i) {
		this.input = i;
		System.out.println("Input is now " + this.input);
	}
} //end class TV

class Remote
{
	public static void main(String[] args) {
		TV t = new TV();
		t.togglePower();
		t.changeVolume(10);	
	} //end main
} //end class Remote