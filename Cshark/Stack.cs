class Stack{
    public Node top;
    public int size;

    public Stack(){
        this.top = null;
        this.size = 0;
    }

    public void push(Node node){
        node.setNext(this.top);
        this.size+=1;
        this.top = node;
    }
    public Node pop(){
        exit = this.top;
        if(!this.isEmpty()){
            this.size -=1;
            this.top=this.top.getNext();
        }
            
        return exit;
    }
    public bool isEmpty(){
        return this.top == null;
    }


    public Stack Inverse(){
        Stack Inverse = new Stack();
        while(!this.isEmpty){
            Inverse.push(this.pop());
        }
        return Inverse;
    }

    public static Stack join(Stack a, Stack b){
        Stack Inverse = b.Inverse;
        while(!Inverse.isEmpty()){
            a.push(Inverse.pop());
        }
    }

}