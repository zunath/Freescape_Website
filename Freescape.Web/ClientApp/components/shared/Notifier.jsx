import * as React from 'react';
import { ToastContainer, toast } from 'react-toastify';

export default class Notifier extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            ShowNotification: props.ShowNotification,
            NotificationMessage: props.NotificationMessage,
            NotificationSuccessful: props.NotificationSuccessful
        }
    }
    
    componentWillUnmount() {
    }

    componentWillReceiveProps(props) {
        this.setState({
            ShowNotification: props.ShowNotification,
            NotificationMessage: props.NotificationMessage,
            NotificationSuccessful: props.NotificationSuccessful
        });
    }

    notify() {
        if (this.state.NotificationSuccessful) {
            toast.success(this.state.NotificationMessage, {
                position: toast.POSITION.TOP_RIGHT,
                onOpen: () => this.setState({ ShowNotification: false })
            });
        }
        else {
            toast.error(this.state.NotificationMessage, {
                position: toast.POSITION.TOP_RIGHT,
                onOpen: () => this.setState({ ShowNotification: false })
            });
        }
    } 
    
    render() {
        return (
            <div>
                {this.state.ShowNotification && this.notify()}

                <ToastContainer />

            </div>
        );



    }
}
