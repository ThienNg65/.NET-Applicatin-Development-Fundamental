<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FillingForm.aspx.cs" Inherits="Lab9_FillingForm_ASPNET.FillingForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register Form</title>
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <script src="bootstrap/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-6 mx-auto">
                    <div class="card">
                        <div class="card-body">

                            <div class="row">
                                <div class="col">
                                    <center>
                                        <h5>Đăng ký khách hàng</h5>
                                    </center>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col">
                                    <hr />
                                </div>
                            </div>

                            <div class="row mb-3">
                                <div class="col">
                                    <h5 class="bg-primary text-white">Thông tin đăng nhập</h5>
                                </div>
                            </div>

                            <div class="row mb-3">
                                <div class="col">
                                    <div class="form-group row">
                                        <label class="col-md-4 form-label">Tên đăng nhập</label>
                                        <div class="col-md-8">
                                            <asp:TextBox CssClass="form-control" ID="txtTenDN" runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator  ID="rf_TenDN" runat="server" ControlToValidate="txtTenDN" ErrorMessage="Tên đăng nhập không được rỗng"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="row mb-3">
                                <div class="col">
                                    <div class="form-group row">
                                        <label class="col-md-4 form-label">Mật khẩu</label>
                                        <div class="col-md-8">
                                            <asp:TextBox CssClass="form-control" ID="txtMK" TextMode="Password" runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rf_MK" runat="server" ControlToValidate="txtMK" ErrorMessage="Mật khẩu không được rỗng"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="row mb-3">
                                <div class="col">
                                    <div class="form-group row">
                                        <label class="col-md-4 form-label">Nhập lại mật khẩu</label>
                                        <div class="col-md-8">
                                            <asp:TextBox CssClass="form-control" ID="txtNhaplaiMK" TextMode="Password" runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator  ID="rf_Nhaplai" runat="server" ControlToValidate="txtNhaplaiMK" ErrorMessage="Nhập lại mật khẩu không được rỗng"></asp:RequiredFieldValidator>
                                            <asp:CompareValidator  ID="cv_Nhaplai" ControlToValidate="txtNhaplaiMK" ControlToCompare="txtMK" runat="server" ErrorMessage="Mật khẩu nhập lại chưa chính xác"></asp:CompareValidator>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col">
                                    <hr />
                                </div>
                            </div>

                            <div class="row mb-3">
                                <div class="col">
                                    <h5 class="bg-primary text-white">Chi tiết</h5>
                                </div>
                            </div>

                            <div class="row mb-3">
                                <div class="col">
                                    <div class="form-group row">
                                        <label class="col-md-4 form-label">Họ tên khách hàng</label>
                                        <div class="col-md-8">
                                            <asp:TextBox CssClass="form-control" ID="txtKH" runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rf_KH" runat="server" ControlToValidate="txtKH" ErrorMessage="Họ tên khách hàng không được rỗng"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="row mb-3">
                                <div class="col">
                                    <div class="form-group row">
                                        <label class="col-md-4 form-label">Ngày sinh</label>
                                        <div class="col-md-8">
                                            <asp:TextBox CssClass="form-control" TextMode="Date" ID="txtNgaySinh" runat="server"></asp:TextBox>
                                            <asp:CompareValidator ID="cv_Ngaysinh" runat="server" ControlToValidate="txtNgaySinh" Operator="DataTypeCheck" Type="Date" ErrorMessage="Ngày sinh không hợp lệ"></asp:CompareValidator>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="row mb-3">
                                <div class="col">
                                    <div class="form-group row">
                                        <label class="col-md-4 form-label">Giới tính</label>
                                        <div class="col-md-8">
                                            <div class="row">
                                                <div class="col-md-6">
                                                    <asp:RadioButton GroupName="gender" ID="radNam" runat="server" />
                                                    <label class="form-label">Nam</label>
                                                </div>

                                                <div class="col-md-6">
                                                    <asp:RadioButton GroupName="gender" ID="radNu" runat="server" />
                                                    <label class="form-label">Nữ</label>                                                
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="row mb-3">
                                <div class="col">
                                    <div class="form-group row">
                                        <label class="col-md-4 form-label">Email</label>
                                        <div class="col-md-8">
                                            <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server"></asp:TextBox>
                                            <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ValidationExpression="^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$" ErrorMessage="Email không hợp lệ"></asp:RegularExpressionValidator>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="row mb-3">
                                <div class="col">
                                    <div class="form-group row">
                                        <label class="col-md-4 form-label">Thu nhập</label>
                                        <div class="col-md-8">
                                            <asp:TextBox CssClass="form-control" ID="txtThuNhap" runat="server"></asp:TextBox>
                                            <asp:RangeValidator ID="rvThuNhap" runat="server" ControlToValidate="txtThuNhap" MaximumValue="50000000" MinimumValue="1000000" ErrorMessage="Thu nhập từ 1 triệu đến 50 triệu"></asp:RangeValidator>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col">
                                    <hr />
                                </div>
                            </div>

                            <div class="row mb-3">
                                <div class="col">
                                    <div class="form-group d-grid gap-2 col-6 mx-auto">
                                        <asp:Button CssClass="btn btn-primary" ID="btnDangky" runat="server" Text="Đăng ký" OnClick="btnDangky_Click" />
                                    </div>
                                </div>
                            </div>

                            <div class="row mb-3">
                                <div class="col mx-auto">
                                    <center>
                                        <asp:Label ID="lblThongBao" runat="server" Text="Thông báo ở đây"></asp:Label>
                                    </center>
                                </div>
                            </div>
                            <asp:ValidationSummary ID="vsTonghop" runat="server" HeaderText="Danh sách các lỗi" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="bootstrap/js/bootstrap.bundle.min.js"></script>
</body>
</html>
