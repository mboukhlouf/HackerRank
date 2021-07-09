import React, { useState } from 'react';
import './App.css';
import 'h8k-components';

import Articles from './components/Articles';

const title = "Sorting Articles";

const Sorting = {
    MOST_UPVOTED: 0,
    MOST_RECENT: 1
};

function App({articles}) {
    const [sorting, setSorting] = useState(Sorting.MOST_UPVOTED);

    const sortingFunctions = {};
    sortingFunctions[Sorting.MOST_UPVOTED] = (articles) => {
        articles.sort((a, b) => {
            return b.upvotes - a.upvotes;
        });
    };

    sortingFunctions[Sorting.MOST_RECENT] = (articles) => {
        articles.sort((a, b) => {
            return new Date(b.date) - new Date(a.date);
        });
    };

    sortingFunctions[sorting](articles);

    return (
        <div className="App">
            <h8k-navbar header={title}></h8k-navbar>
            <div className="layout-row align-items-center justify-content-center my-20 navigation">
                <label className="form-hint mb-0 text-uppercase font-weight-light">Sort By</label>
                <button data-testid="most-upvoted-link"
                    className="small"
                    onClick={() => setSorting(Sorting.MOST_UPVOTED)}>Most Upvoted</button>
                <button data-testid="most-recent-link" 
                    className="small"
                    onClick={() => setSorting(Sorting.MOST_RECENT)}>Most Recent</button>
            </div>
            <Articles articles={articles}/>
        </div>
    );

}

export default App;
