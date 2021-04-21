namespace Section6InterfacesAreNotForMultipleInheritance
{
    public class TextBox : UiControl, IDraggable, IDroppable
    {   
        public void Drag()
        {
            throw new System.NotImplementedException();
        }

        public void Drop()
        {
            throw new System.NotImplementedException();
        }
    }
}