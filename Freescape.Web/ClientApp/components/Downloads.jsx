import * as React from 'react';
import * as dotnetify from 'dotnetify';

export default class Downloads extends React.Component {
    constructor(props) {
        super(props);
        this.vm = dotnetify.react.connect('DownloadsViewModel', this);
        this.state = { DownloadList: [] }
    }

    componentWillUnmount() {
        this.vm.$destroy();
    }

    render() {
        return (
            <div>
                
                <h2 className="center">Downloads</h2>
                <div className="row">&nbsp;</div>
                <div className="card border-primary mb-3">
                    <div className="card-body">
                        <h4 className="card-title center">Automatic Downloads</h4>
                        <p className="card-text">
                            The recommended way to download the required files is to subscribe to the CEP on Steam. Simply click the button below, click "Subscribe" and the files will download automatically!
                            
                            <a className="btn btn-outline-primary btn-block" target="_blank" href="https://steamcommunity.com/sharedfiles/filedetails/?id=1312882397">
                                Subscribe on Steam
                            </a>
                         </p>
                    </div>
                </div>

                <div className="row">&nbsp;</div>


                <div className="card border-primary mb-3">
                    <div className="card-body">
                        <h4 className="card-title center">Manual Downloads</h4>
                        <p className="card-text">
                            If you don't use Steam or would prefer to manually install the required haks, you can find them on the Neverwinter Vault.
                            
                            <a className="btn btn-outline-primary btn-block" target="_blank" href="https://neverwintervault.org/cep">
                                Download on NWN Vault
                            </a>

                        </p>
                    </div>
                </div>
                
            
            </div>
        );



    }
}
