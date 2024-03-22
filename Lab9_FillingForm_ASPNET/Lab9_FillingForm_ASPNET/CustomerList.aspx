<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerList.aspx.cs" Inherits="Lab9_FillingForm_ASPNET.CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <script src="bootstrap/js/bootstrap.bundle.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            <div class="col">
                <div class="row">
                    <div class="col">
                        <center>
                            <h4>Danh sách khách hàng</h4>
                        </center>
                    </div>
                </div>

                <div class="row">
                    <div class="col">
                        <br />
                    </div>
                </div>

                <div class="row">
                    <div class="col">
                        <asp:GridView CssClass="table table-striped table-bordered" ID="grCustomer" runat="server"
                            BackColor="White" BorderColor="#CCCCCC"
                            BorderStyle="None" BorderWidth="1px"
                            OnRowCommand="grCustomer_RowCommand" OnRowEditing="grCustomer_RowEditing" OnRowCancelingEdit="grCustomer_RowCancelingEdit"
                            OnRowUpdating="grCustomer_RowUpdating" OnRowDeleting="grCustomer_RowDeleting"
                            AutoGenerateColumns="false" AllowPaging="true" OnPageIndexChanging="grCustomer_PageIndexChanging" PageSize="5"
                            DataKeyNames="TenDN"
                            CellPadding="5">
                            <Columns>

                                <asp:TemplateField ItemStyle-Width="100px" HeaderText="Tên đăng nhập">
                                    <ItemTemplate>
                                        <asp:Label ID="lblTenDN" runat="server" Text='<%# Eval("TenDN") %>'></asp:Label>
                                    </ItemTemplate>

                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtTenDN" runat="server" Text='<%# Eval("TenDN") %>' ReadOnly="true"></asp:TextBox>
                                    </EditItemTemplate>

                                    <ItemStyle Width="100px"></ItemStyle>
                                </asp:TemplateField>

                                <asp:TemplateField ItemStyle-Width="100px" HeaderText="Họ tên">
                                    <ItemTemplate>
                                        <asp:Label ID="lblHoTen" runat="server" Text='<%# Eval("HoTen") %>'></asp:Label>
                                    </ItemTemplate>

                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtHoTen" runat="server" Text='<%# Eval("HoTen") %>'></asp:TextBox>
                                    </EditItemTemplate>

                                    <ItemStyle Width="100px"></ItemStyle>
                                </asp:TemplateField>

                                <asp:TemplateField ItemStyle-Width="100px" HeaderText="Ngày sinh">
                                    <ItemTemplate>
                                        <asp:Label ID="lblNgaySinh" runat="server" Text='<%# Eval("NgaySinh", "{0:dd/MM/yyyy}") %>'></asp:Label>
                                    </ItemTemplate>

                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtNgaySinh" runat="server" Text='<%# Eval("NgaySinh", "{0:dd/MM/yyyy}") %>'></asp:TextBox>
                                    </EditItemTemplate>

                                    <ItemStyle Width="100px"></ItemStyle>
                                </asp:TemplateField>

                                <asp:TemplateField ItemStyle-Width="100px" HeaderText="Giới tính">
                                    <ItemTemplate>
                                        <asp:Label ID="lblGioiTinh" runat="server" Text='<%# Eval("GioiTinh") %>'></asp:Label>
                                    </ItemTemplate>

                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtGioiTinh" runat="server" Text='<%# Eval("GioiTinh") %>'></asp:TextBox>
                                    </EditItemTemplate>

                                    <ItemStyle Width="100px"></ItemStyle>
                                </asp:TemplateField>

                                <asp:TemplateField ItemStyle-Width="100px" HeaderText="Email">
                                    <ItemTemplate>
                                        <asp:Label ID="lblEmail" runat="server" Text='<%# Eval("Email") %>'></asp:Label>
                                    </ItemTemplate>

                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtEmail" runat="server" Text='<%# Eval("Email") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemStyle Width="100px"></ItemStyle>
                                </asp:TemplateField>

                                <asp:TemplateField ItemStyle-Width="150px" HeaderText="">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="btnEdit" CommandName="Edit" ToolTip="Edit" runat="server">Edit</asp:LinkButton>
                                        <asp:LinkButton ID="btnDelete" CommandName="Delete" ToolTip="Delete" runat="server">Delete</asp:LinkButton>
                                        <asp:LinkButton ID="btnSelect" CommandName="Select" ToolTip="Select" runat="server">Select</asp:LinkButton>
                                    </ItemTemplate>

                                    <EditItemTemplate>
                                        <asp:LinkButton ID="btnUpdate" CommandName="Update" ToolTip="Update" runat="server">Update</asp:LinkButton>
                                        <asp:LinkButton ID="Cancel" CommandName="Cancel" ToolTip="Cancel" runat="server">Cancel</asp:LinkButton>
                                        <asp:LinkButton ID="btnSelect" CommandName="Select" ToolTip="Select" runat="server">Select</asp:LinkButton>
                                    </EditItemTemplate>

                                    <ItemStyle Width="50px"></ItemStyle>
                                </asp:TemplateField>
                            </Columns>
                            <FooterStyle BackColor="White" ForeColor="#000066" />
                            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                            <RowStyle ForeColor="#000066" />
                            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#007DBB" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#00547E" />
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </form>

    <script src="bootstrap/js/bootstrap.bundle.min.js"></script>
</body>
</html>
