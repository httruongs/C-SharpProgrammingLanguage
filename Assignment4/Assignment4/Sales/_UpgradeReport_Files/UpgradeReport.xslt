@std@@6B@ ??0exception@std@@$$FQAE@ABQBD@Z ??_R4bad_alloc@std@@6B@ ??_R0?AVbad_alloc@std@@@8 ??_7type_info@@6B@ ??_R3bad_alloc@std@@8 ??_R2bad_alloc@std@@8 ??_R1A@?0A@EA@bad_alloc@std@@8 ??_R1A@?0A@EA@exception@std@@8 ??_R0?AVexception@std@@@8 ??_R3exception@std@@8 ??_R2exception@std@@8 ??_Ebad_alloc@std@@UAEPAXI@Z ?what@exception@std@@UBEPBDXZ __t2m@??0bad_alloc@std@@QAE@PBD@Z __mep@??0bad_alloc@std@@$$FQAE@PBD@Z .rdata$ilfixup ??_Ebad_alloc@std@@$$FUAEPAXI@Z ??3@$$FYAXPAX@Z ??_M@$$FYMXPAXIHP6MX0@Z@Z ??1ba= @Project)">

                    <xsl:variable name="ProjectName" select="@Project"/>

                    <project>
                        <xsl:attribute name="name">
                            <xsl:value-of select="@Project"/>
                        </xsl:attribute> 

                        <xsl:if test="@Project=''">
                        <xsl:attribute name="solution">
                            <xsl:value-of select="@Solution"/>
                        </xsl:attribute> 
          move@@$$J0YAPAXPAXPBXI@Z __t2m@_wmemmove __mep@?wmemmove@@$$J0YAPA_WPA_WPB_WI@Z .rdata$ilfixup ?copy@?$char_traits@_W@std@@$$FSAPA_WPA_WPB_WI@Z __t2m@?copy@?$char_traits@_W@std@@SAPA_WPA_WPB_WI@Z __mep@?copy@?$char_traits@_W@std@@$$FSAPA_WPA_WPB_WI@Z .rdata$ilfixup ?move@?$char_traits@_W@std@@$$FSAPA_WPA_WPB_WI@Z __t2m@?move@?$char_traits@_W@std@@SAPA_WPA_WPB_WI@Z __mep@?move@?$char_traits@_W@std@@$$FSAPA_WPA_WPB_WI@Z .rdata$ilfixup ?assign@?$char_traits@_W@std@@$$FSAXAA_WAB_W@Z __t2m@?assign@?$char_traits@te>

                                    <xsl:variable name="Source">
                                        <xsl:value-of select="@Source"/>
                                    </xsl:variable>

                                    <xsl:for-each select="key('ProjectKey', $ProjectName)[ @Source = $Source ]">

                                        <event>
                                            <xsl:attribute name="error-level">
                                                <xsl:value-of sel__t2m@??$move@AAV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@std@@YA$$QAV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@0@AAV10@@Z __mep@??$move@AAV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@std@@$$FYA$$QAV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@0@AAV10@@Z .rdata$ilfixup ?length@?$char_traits@D@std@@$$FSAIPBD@Z ?strlen@@$$J0YAIPBD@Z __t2m@?length@?$char_traits@D@std@@SAIPBD@Z __mep@?length@?$char_traits@D@std@@$$FSAIPBD@Z .rdata$ilfixup ?copy@?$c           </xsl:for-each>

                    </project>
                </xsl:if>
            </xsl:for-each>
        </projects>
    </xsl:template>

    <xsl:template match="projects">
    <xsl:for-each select="project">
    <xsl:sort select="@Name" order="ascending"/>
        <h2>
        <xsl:if test="@solution"><a _locID="Solution">Solution</a>: <xsl:value-of select="@solution"/></xsl:if>
        <xsl:if test="not(@solution)"><a _locID="Project">Project</a>: <xsl:value-of select="@name" __t2m@?eq_int_type@?$char_traits@D@std@@SA_NABH0@Z __mep@?eq_int_type@?$char_traits@D@std@@$$FSA_NABH0@Z .rdata$ilfixup ?eof@?$char_traits@D@std@@$$FSAHXZ __t2m@?eof@?$char_traits@D@std@@SAHXZ __mep@?eof@?$char_traits@D@std@@$$FSAHXZ .rdata$ilfixup ??0_Container_proxy@std@@$$FQAE@XZ __t2m@??0_Container_proxy@std@@QAE@XZ __mep@??0_Container_proxy@std@@$$FQAE@XZ .rdata$ilfixup ?_Orphan_me@_Iterator_base12@std@@$$FQAEXXZ ?_Debug_message@std@@$$FYAXPB_W0I@Z ??_C@_1JA@HCKHPKJH@?$AAc?$AA?3?$AA?2?$AAP?$AAr?$AAo?$te" class="infotable">
            <tr>
                <td nowrap="1" class="header" _locID="Filename">Filename</td>
                <td nowrap="1" class="header" _locID="Status">Status</td>
                <td nowrap="1" class="header" _locID="Errors">Errors</td>
                <td nowrap="1" class="header" _locID="Warnings">Warnings</td>
            </tr>

            <xsl:for-each select="source">
                <xsl:sort select="@name" order="ascending"/>
                <xsl:variable name=data$ilfixup ??0runtime_error@std@@$$FQAE@ABV01@@Z ??_7runtime_error@std@@6B@ ??0exception@std@@$$FQAE@ABV01@@Z ??_R4runtime_error@std@@6B@ ??_R0?AVruntime_error@std@@@8 ??_R3runtime_error@std@@8 ??_R2runtime_error@std@@8 ??_R1A@?0A@EA@runtime_error@std@@8 ??_Eruntime_error@std@@UAEPAXI@Z __t2m@??0runtime_error@std@@QAE@ABV01@@Z __mep@??0runtime_error@std@@$$FQAE@ABV01@@Z .rdata$ilfixup ??1system_error@std@@$$FUAE@XZ __t2m@??1system_error@std@@UAE@XZ __mep@??1system_error@std@@$$FUAE@XZ .rdata$ilfixup ??0syeport_Files/UpgradeReport_Plus.gif" width="9" ><xsl:attribute name="name"><xsl:value-of select="$source-id"/></xsl:attribute><xsl:attribute name="child">src<xsl:value-of select="$source-id"/></xsl:attribute></IMG></A>&#32;<xsl:value-of select="@name"/> 
                    </td>
                    <td class="content">
                        <xsl:if test="count(event[@error-level='3'])=1">
                            <xsl:for-each select="event[@error-level='3']">
                            <xsl:if tDU?$char_traits@D@std@@V?$allocator@D@2@@std@@$$FQBEIXZ .rdata$ilfixup ?_Myptr@?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@$$FQBEPBDXZ __t2m@?_Myptr@?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@QBEPBDXZ __mep@?_Myptr@?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@$$FQBEPBDXZ .rdata$ilfixup ??0?$allocator@D@std@@$$FQAE@XZ __t2m@??0?$allocator@D@std@@QAE@XZ __mep@??0?$allocator@D@std@@$$FQAE@XZ .rdata$ilfixup ??0?$allocator@D@std@@$$FQAE@ABV01@@Z __t2m@??0?$alloc>
                    <td class="content"><xsl:value-of select="count(event[@error-level='2'])"/></td>
                    <td class="content"><xsl:value-of select="count(event[@error-level='1'])"/></td>
                </tr>

                <tr class="collapsed" bgcolor="#ffffff">
                    <xsl:attribute name="id">src<xsl:value-of select="$source-id"/></xsl:attribute>

                    <td colspan="7">
                        <table width="97%" border="1" bordercolor="#dcdcdc" rulesYAXABU_Bool_struct@1@@Z __t2m@??Bsentry@?$basic_ostream@DU?$char_traits@D@std@@@std@@QBEP6AXABU_Bool_struct@2@@ZXZ __mep@??Bsentry@?$basic_ostream@DU?$char_traits@D@std@@@std@@$$FQBEP6AXABU_Bool_struct@2@@ZXZ .rdata$ilfixup ?get_allocator@?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@$$FQBE?AV?$allocator@D@2@XZ __t2m@?get_allocator@?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@QBE?AV?$allocator@D@2@XZ __mep@?get_allocator@?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@:solid 1 lightgray">
                                        <xsl:value-of select="@description"/>
                                    </td>
                                </tr>
                                </xsl:if>
                            </xsl:for-each>
                        </table>
                    </td>
                </tr>
                </xsl:if>
            </xsl:for-each>

            <tr valign="top">
                <td class="foot">
                    <xsl:if test=D@std@@$$FQAEXPADI@Z .rdata$ilfixup ?_Myptr@?$basic_string@_WU?$char_traits@_W@std@@V?$allocator@_W@2@@std@@$$FQBEPB_WXZ __t2m@?_Myptr@?$basic_string@_WU?$char_traits@_W@std@@V?$allocator@_W@2@@std@@QBEPB_WXZ __mep@?_Myptr@?$basic_string@_WU?$char_traits@_W@std@@V?$allocator@_W@2@@std@@$$FQBEPB_WXZ .rdata$ilfixup ??0?$allocator@_W@std@@$$FQAE@ABV01@@Z __t2m@??0?$allocator@_W@std@@QAE@ABV01@@Z __mep@??0?$allocator@_W@std@@$$FQAE@ABV01@@Z .rdata$ilfixup ??0_Sentry_base@?$basic_ostream@DU?$char_traits@D@std@@@ed">Not converted</a>:&#32;<xsl:value-of select="count(source) - count(source/event[@error-level='3' and @description='Converted'])"/>
                </td>
                <td class="foot"><xsl:value-of select="count(source/event[@error-level='2'])"/></td>
                <td class="foot"><xsl:value-of select="count(source/event[@error-level='1'])"/></td>
            </tr>
        </table>
    </xsl:for-each>
    </xsl:template>

    <xsl:template match="Property">
        <xsl:if test="@Name!='D