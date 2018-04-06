import * as React from 'react';
import { Carousel } from 'react-responsive-carousel';
import { Link } from 'react-router-dom';

export default class Home extends React.Component {
    render() {
        return (
            <div>

                <h1 className="center">Welcome to Freescape!</h1>
                <h3 className="center">A Neverwinter Nights: Enhanced Edition Server</h3>
                <h4 className="center">
                    Direct Connect: freescape.eastus.cloudapp.azure.com:5121 <Link to="/downloads"><i>(Download Files)</i></Link>
                </h4>

                <h5 className="center">
                <i><a href="http://store.steampowered.com/app/704450/Neverwinter_Nights_Enhanced_Edition/" target="_blank">Buy NWN today on Steam</a></i> or <i><a href="https://www.beamdog.com/products/neverwinter-nights-enhanced-edition#signup-form" target="_blank">directly from Beamdog! </a></i>
                </h5>

                <Carousel showArrows={true} autoPlay={true} infiniteLoop={true} useKeyboardArrows={true} stopOnHover={true} dynamicHeight={true}>
                    
                </Carousel>

            </div>
        );



    }
}
