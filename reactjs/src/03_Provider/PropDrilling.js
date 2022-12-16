import React from 'react';

const PropDrilling = () => {
  const data = {
    listItem: 'PropDrilling',
    title: 'Title',
    text: 'Text',
  };

  return (
    <div>
      <SideBar data={data} />
      <Content data={data} />
    </div>
  );
};

const SideBar = ({ data }) => <List data={data} />;
const List = ({ data }) => <ListItem data={data} />;
const ListItem = ({ data }) => <span>{data.listItem}</span>;

const Content = ({ data }) => (
  <div>
    <Header data={data} />
    <Block data={data} />
  </div>
);
const Header = ({ data }) => <div>{data.title}</div>;
const Block = ({ data }) => <Text data={data} />;
const Text = ({ data }) => <div>{data.text}</div>;

export default PropDrilling;
