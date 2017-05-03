float y=360;
float v=0;
float x=0;

void setup(){
  size(960,720);
  background(0);
  stroke(255);
  strokeWeight(5);
}

void draw(){
  x++;
  v=v-0.1;
  y=y-v;
  point(x,y);
}

void mousePressed() {
  v=v+5;
}