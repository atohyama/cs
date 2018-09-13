using System;

public class Arr_data {
  public float pos_x, pos_y, pos_z;
  public float rot_x, rot_y, rot_z;
  public string arr_name;
  public string arr_text;
}

public class Room {
  public string room_name;
  public int arr_num;
  public Arr_data[] arrows;

  // constructer
  public Room(string room_name, int arr_num) {
    this.room_name = room_name;
    this.arr_num = arr_num;
    this.arrows = new Arr_data[this.arr_num];
    for (int i= 0; i < arr_num; i++) {
      arrows[i] = new Arr_data();
    }
  }

  public void setArrowPos(int index, float pos_x, float pos_y, float pos_z) {
    this.arrows[index].pos_x = pos_x;
    this.arrows[index].pos_y = pos_y;
    this.arrows[index].pos_z = pos_z;
  }

  public void setArrowRot(int index, float rot_x, float rot_y, float rot_z) {
    this.arrows[index].rot_x = rot_x;
    this.arrows[index].rot_y = rot_y;
    this.arrows[index].rot_z = rot_z;
  }

  public void setArrow

  // public string getArrText() {
  //   return this.arr_text[0];
  // }
  // a
}

public class RoomTest {
  static public void Main ()
  {
    Room r = new Room("lou1", 4);

    r.setArrowPos(0, 10, 20, 30);
    Console.WriteLine(r.arrows[0].pos_x);
  }
}
