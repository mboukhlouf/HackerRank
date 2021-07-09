import React, {useState} from 'react';

function Slides({slides}) {
    const [currentSlideIndex, setCurrentSlideIndex] = useState(0);
    const currentSlide = slides[currentSlideIndex];
    const isFirstSlide = currentSlideIndex === 0;
    const isLastSlide = currentSlideIndex === slides.length - 1;
    
    const restart = () => {
        if(!isFirstSlide)
        {
            setCurrentSlideIndex(0);
        } 
    };

    const next = () => {
        if(!isLastSlide)
        {
            setCurrentSlideIndex(currentSlideIndex + 1);
        }
    };

    const prev = () => {
        if(!isFirstSlide)
        {
            setCurrentSlideIndex(currentSlideIndex - 1);
        }
    };

    return (
        <div>
            <div id="navigation" className="text-center">
                <button 
                    data-testid="button-restart" 
                    className="small outlined"
                    onClick={restart}
                    disabled={isFirstSlide}>Restart</button>
                <button 
                    data-testid="button-prev" 
                    className="small"
                    onClick={prev}
                    disabled={isFirstSlide}>Prev</button>
                <button 
                    data-testid="button-next" 
                    className="small"
                    onClick={next}
                    disabled={isLastSlide}>Next</button>
            </div>
            <div id="slide" className="card text-center">
                <h1 data-testid="title">{currentSlide.title}</h1>
                <p data-testid="text">{currentSlide.text}</p>
            </div>
        </div>
    );

}

export default Slides;
