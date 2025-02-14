export const Section = ({props}) =>{
    return(
        <div>
            <h2>Hello from section commponent!</h2>
            <section className="" style={{backgroundColor: colorName }}>
                <p>{props.colorName? props.colorName : "plese write a color in input"}</p>
            </section>
        </div>
    )
}