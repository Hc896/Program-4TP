export const TestComponent = () => {

    const handleClick = () => {
        console.log("button was clicked");
    }
    return(
        <div>
            <h3>HalloWorld! z nowego Componentu TestComponent</h3>
            <button onClick={handleClick}>Click me</button>
        </div>
    )
}