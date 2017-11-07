package umich.cse.yctung.libacousticsensing.Network;

/**
 * Created by Yu-Chih Tung on 10/15/15.
 * yctung: this is a request queue used for network communication
 */
public class NetworkRequest {
    public int action;
    public String name;
    public byte[] data;
    public int type;
    public float arg0;
    public float arg1;
    public int code;
    public int stamp;
    NetworkRequest(int actionIn, String nameIn, byte[] dataIn, int typeIn){
        action = actionIn;
        name = nameIn;
        data = dataIn;
        type = typeIn;
    }

    NetworkRequest(int actionIn, int stampIn, String nameIn, int codeIn, float arg0In, float arg1In, byte[] dataIn, int typeIn){
        action = actionIn;
        name = nameIn;
        data = dataIn;
        type = typeIn;
        code = codeIn;
        arg0 = arg0In;
        arg1 = arg1In;
        data = dataIn;
        type = typeIn;
        stamp = stampIn;
    }

}
