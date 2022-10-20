import java.io.*;


public class MainSimulation extends GlobalSimulation{
 
    public static void main(String[] args) throws IOException {

    	Event actEvent;
    	EventList myEventList = new EventList();
    	State actState = new State(myEventList);

        myEventList.InsertEvent(ARRIVAL, 0, A);
        myEventList.InsertEvent(MEASURE, 0.1, M);

    	while (time < 1000){
		//while(actState.noMeasurements < 1000){

    		actEvent = myEventList.FetchEvent();

    		time = actEvent.eventTime;
    		actState.TreatEvent(actEvent);
			//System.out.println("Time: " + time);
            //time++;
    	}
    	System.out.println("Mean number of customers: " + 1.0*actState.accumulated/actState.noMeasurements);
		System.out.println("Mean number of B jobs: " + actState.accumulatedB/actState.noMeasurements);
    	System.out.println("Number of measurements done: " + actState.noMeasurements);
    }
}