class GenerateResources extends React.Component {
    constructor(props) {
        super(props);

        this.handleSubmit = this.handleSubmit.bind(this);
        this.fileInput = React.createRef();
    }

    handleSubmit(event) {
        // highlight-range{3}
        event.preventDefault();
        alert(
            `Selected file - ${this.fileInput.current.files[0].name}`
        );
    }


    render() {
        return (
            <form onSubmit={this.handleSubmit}>
                <a><b>Upload excel file</b></a>
                <a> </a>
                <input type="file" ref={this.fileInput} />

                <br></br>

                <a><b>Generete .resx files</b></a>
                <a> </a>
                <button type="submit" onClick={this.onClick}>Generate</button>
            </form>
        );
    }
}

class GenerateExcel extends React.Component {
    constructor(props) {
        super(props);

        this.handleSubmit = this.handleSubmit.bind(this);
        this.fileInput = React.createRef();
    }

    handleSubmit(event) {
        // highlight-range{3}
        event.preventDefault();
        alert(
            `Selected file - ${this.fileInput.current.files[0].name}`
        );
    }


    render() {
        return (
            <form onSubmit={this.onSubmit}>
                <a><b>Entered folder with .resx files</b></a>
                <a> </a>
                <input type="file" ref={this.fileInput} />

                <br></br>

                <a><b>Generete .excel file</b></a>
                <a> </a>
                <button onClick={this.onClick}>Generate</button>
            </form>
        );
    }
}


class GenerateBase extends React.Component {
    constructor(props) {
        super(props);
    }

    render() {
        var add = this.onAddEmployee;

        return <table width="100%">
            <tbody>
                <div>
                    <th width="0%">
                        <td align="left">
                            <h2>Generate .resx</h2>
                            <GenerateResources />
                        </td>
                    </th>

                    <th width="0%">
                        <td align="left">
                            <h2>Generate .excel</h2>
                            <GenerateExcel />
                        </td>
                    </th>
                </div>
            </tbody>
        </table>
    }
}

ReactDOM.render(
    <GenerateBase />,
    document.getElementById("content")
);
//apiUrl="/api/Employee"