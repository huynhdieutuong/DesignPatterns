import React from 'react';
import Button from '@mui/material/Button';
import FormControlLabel from '@mui/material/FormControlLabel';
import Switch from '@mui/material/Switch';
import observable from './Observable';
import { alert, logger } from './observerFunctions';

/**
 * With the observer pattern, we can subscribe certain objects (observers) to another object (observable).
 * Whenever an event occurs, the observable notifies all its observers!
 */

// 1. Register logger and alert to observable object
observable.subscribe(logger);
observable.subscribe(alert);

const AppObserver = () => {
  // 2. When click or toggle, the observable notifies all its observers
  const handleClick = () => observable.notify('User clicked button!');
  const handleToggle = () => observable.notify('User toggled switch!');

  return (
    <div>
      <Button variant="contained" onClick={handleClick}>
        Click me!
      </Button>
      <FormControlLabel
        control={<Switch defaultChecked onChange={handleToggle} />}
        label="Toggle me!"
      />
    </div>
  );
};

export default AppObserver;
