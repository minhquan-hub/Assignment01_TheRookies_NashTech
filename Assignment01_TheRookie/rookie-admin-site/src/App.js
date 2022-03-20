import logo from './logo.svg';
import { lazy, Suspense } from 'react';
import './App.css';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import Navbar from './components/Narbar';
import { PRODUCT } from './Constants/pages';
import { CATEGORY } from './Constants/pages';
import InLineLoader from './share-components/InlineLoader';

const Product = lazy(() => import('./components/Product'));
const Category = lazy(() => import('./components/Category'));

const SusspenseLoading = ({ children }) => (
  <Suspense fallback={<InLineLoader />}>{children}</Suspense>
);

function App() {
  return (
    <Router>
      <div className="App">
        <Navbar onSearchKey={(e) => e.target.value}></Navbar>

        <SusspenseLoading>
          <Switch>
            <Route exact path="/"></Route>
            <Route exact path="/contact"></Route>
            <Route exact path="/hello"></Route>
            <Route path={PRODUCT}>
              <Product />
            </Route>
            <Route path={CATEGORY}>
              <Category />
            </Route>
          </Switch>
        </SusspenseLoading>
      </div>
    </Router>
  )
}

export default App
