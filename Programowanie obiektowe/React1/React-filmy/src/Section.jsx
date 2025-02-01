export const Section = ( props ) => {
    return (
        <div>
            <h2>Hello from Section component!</h2>
            <section className='' style={{backgroundColor: props.colorNameProps}}> 
        
            <p>{props.colorNameProps? props.colorNameProps : "please write a color name in input"}</p>
            </section>
        </div>
    )
}