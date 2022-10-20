import java.io.IOException;

public class MainSimulation extends GlobalSimulation{
	
	

    public static void main(String[] args) throws IOException {
    	Event actEvent;
    	EventList myEventList = new EventList();
    	State actState = new State(myEventList);
		
		
			
       	myEventList.InsertEvent(ARRIVAL, 0);
        myEventList.InsertEvent(MEASURE, 5);
    	while (time < 200000){
    		actEvent = myEventList.FetchEvent();
    		time = actEvent.eventTime;
    		actState.TreatEvent(actEvent);
    	}
		int measureNbr = actState.noMeasurements;
		double meanNbr = 1.0*actState.accumulated/measureNbr;
		
    	System.out.println("Mean number of customers: " + meanNbr);
    	System.out.println("Number of measurements done: " + measureNbr);
		
	}
	
}