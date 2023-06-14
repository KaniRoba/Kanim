class Node{
    private object element;
    private Node next;

    public Node(){
        this(null);
    }
    public(Object element){
        this.next = null;
        this.element = element;
    }
    public void setNext(Node next){
        this.next = next;
    }
    public Node getNext(){
        return this.next;
    }
    public void setElement(element){
        this.element = element;
    } 
    public Object getElement(){
        return this.element;
    }
}