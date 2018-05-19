Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace OsmGeocodeSample
    Partial Public Class MainForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#ConfigureMapLayers"
        Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            mapControl.Layers.AddRange(New LayerBase() { _
                New ImageLayer With { _
                    .DataProvider = New OpenStreetMapDataProvider() With {.TileUriTemplate = "YOUR_TILE_SERVICE.com/{1}/{2}/{3}"} _
                }, _
                _
                New InformationLayer With {.DataProvider = New OsmGeocodeDataProvider()} _
            })
        End Sub
        #End Region ' #ConfigureMapLayers
    End Class
End Namespace
