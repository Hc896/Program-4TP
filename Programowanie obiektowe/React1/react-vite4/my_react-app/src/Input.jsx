export const Input = ({colorNameProps,handleInputChange,handleSubmit}) =>{
    return(
        <div>
            <h2>Hello from input commponent!</h2>

            <form onSubmit={handleSubmit}>
                <input
                    autoFocus
                    type="text"
                    placeholder='enter a color name'
                    required
                    value={colorNameProps}
                    onChange={handleInputChange}>
        
                </input>
            </form>
        </div>
    )
}