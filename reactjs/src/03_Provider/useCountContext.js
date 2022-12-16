import { useContext } from 'react';
import { CountContext } from './CountContextProvider';

const useCountContext = () => {
  const context = useContext(CountContext);

  if (!context)
    throw new Error(
      'useCountContext has to be used within CountContextProvider'
    );

  return context;
};

export default useCountContext;
