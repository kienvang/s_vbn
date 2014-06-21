<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AdvertMulti.ascx.cs" Inherits="Modules_Adverts_Controls_AdvertMulti" %>
<%@ Register Src="../../Controls/BoxImageFlash.ascx" TagName="BoxImageFlash" TagPrefix="uc1" %>

<script type="text/javascript">
    $(document).ready(function(){
        $(".sli<%= ClientID %>").s3Slider({
            timeOut: 4000
        });
    });
</script>

<li>
    <div id="slider" class="sli<%= ClientID %>" style="width: <%= FWidth %>px; height: <%= FHeight %>px">
        <ul id="sliderContent" class="sli<%= ClientID %>Content" style="width: 195px; height: 120px">
            <asp:Repeater ID="repAdvert" runat="server">
                <ItemTemplate>
                    <li class="sliderImage sli<%= ClientID %>Image" <%# Container.ItemIndex == 0 ? "style='display:block'" : "style='display:none'" %> >
                        <uc1:BoxImageFlash ID="BoxImageFlash1" runat="server" MediaName='<%# Eval("AdvertName") %>'
                            MediaPath='<%# Eval("Path") %>' MediaAddress='<%# Eval("AddressUrl") %>' MediaType='<%# Eval("Type") %>'
                            FWidth="<%# FWidth %>" FHeight="<%# FHeight %>" FWidth2='<%# Eval("Width") %>' FHeight2='<%# Eval("Height") %>' />
                        <span></span></li>
                </ItemTemplate>
            </asp:Repeater>
            <div class="clear sliderImage sli<%= ClientID %>Image">
            </div>
        </ul>
    </div>
</li>
<%--<li class="sliderImage sli<%= ClientID %>Image"><a href="">
            <img src="/images/410/1.jpg" alt="1" width="195px" height="120px" /></a> <span>
            </span></li>
        <li class="sliderImage sli<%= ClientID %>Image"><a href="">
            <img src="/images/410/2.jpg" alt="2" width="195px" height="120px" /></a> <span>
            </span></li>
        <li class="sliderImage sli<%= ClientID %>Image">
            <img src="/images/410/3.jpg" alt="3" width="195px" height="120px" />
            <span></span></li>
        <li class="sliderImage sli<%= ClientID %>Image">
            <img src="/images/410/4.jpg" alt="4" width="195px" height="120px" />
            <span></span></li>
        <li class="sliderImage sli<%= ClientID %>Image">
            <img src="/images/410/5.jpg" alt="5" width="195px" height="120px" />
            <span></span></li>
        <div class="clear sliderImage sli<%= ClientID %>Image">
        </div>
    --%>
