namespace ssConectaProveedores {
/// <summary>
/// [Structure] CommissionsAndLeasesFileStruct (Hz1S7W+8BUe55e7GAKlwug)
///  <code>ST_0a2958ff44247d7464fd88ba7a80597cStructure</code> that represent
/// s <code>CommissionsAndLeasesFileStruct</code> <p>Description: Commissions and Leases File
///  Struct.</p>
/// </summary>
// Name: CommissionsAndLeasesFileStruct
public partial struct ST_0a2958ff44247d7464fd88ba7a80597cStructure : ITypedRecord<ST_0a2958ff44247d7464fd88ba7a80597cStructure> {
internal static readonly GlobalObjectKey IdFeContab = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*d6bKRAIBJEKsivsCkkIjJg");
internal static readonly GlobalObjectKey IdEjMes = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*AGo23NS9cEKf_SxDleBwYA");
internal static readonly GlobalObjectKey IdCuenta = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*G+uYR3esCUGZbIU9lj43JA");
internal static readonly GlobalObjectKey IdReferencia = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Yx+rLzF1T0SPyJPZHu0lgQ");
internal static readonly GlobalObjectKey IdNombre1 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*L8znyajfOEScYMjmcHo7PA");
internal static readonly GlobalObjectKey IdNombre2 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*+KSSHky6HEeZoVcXH4m_Ag");
internal static readonly GlobalObjectKey IdNDoc = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5eYA7ur8dE+IL9blGMAOMw");
internal static readonly GlobalObjectKey IdImporteEnML = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_FmEXyUoV0WFRwVunL48hw");
internal static readonly GlobalObjectKey IdML = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Rj6L4J2XX0amuJZskZNgbw");
internal static readonly GlobalObjectKey IdImporteEnMD = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vNyXhRi7zkiZzba1FbMk7g");
internal static readonly GlobalObjectKey IdMon = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PeoKg4HZV06KrBosmNLZug");
internal static readonly GlobalObjectKey IdSoc = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*SkUHP3eTRkesUDpKUbGEzQ");
internal static readonly GlobalObjectKey IdDiv = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*g_FYRzZXjU23GUIOIDf65g");
internal static readonly GlobalObjectKey IdLibMayor = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*yCHKRcIzeEmMSLDZGTRfqQ");
internal static readonly GlobalObjectKey IdTextoCabDocumento = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_DEomGuvYkmu9GeQUCtzcA");
internal static readonly GlobalObjectKey IdDocComp = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8OiiHySqzU+A2N3VG2dVHA");

public string ssFeContab;

public string ssEjMes;

public string ssCuenta;

public string ssReferencia;

public string ssNombre1;

public string ssNombre2;

public string ssNDoc;

public string ssImporteEnML;

public string ssML;

public string ssImporteEnMD;

public string ssMon;

public string ssSoc;

public string ssDiv;

public string ssLibMayor;

public string ssTextoCabDocumento;

public string ssDocComp;


public BitArray OptimizedAttributes;

public ST_0a2958ff44247d7464fd88ba7a80597cStructure() {
OptimizedAttributes = null;
ssFeContab = "";
ssEjMes = "";
ssCuenta = "";
ssReferencia = "";
ssNombre1 = "";
ssNombre2 = "";
ssNDoc = "";
ssImporteEnML = "";
ssML = "";
ssImporteEnMD = "";
ssMon = "";
ssSoc = "";
ssDiv = "";
ssLibMayor = "";
ssTextoCabDocumento = "";
ssDocComp = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssFeContab = r.ReadText(index++, "CommissionsAndLeasesFileStruct.FeContab", "");
ssEjMes = r.ReadText(index++, "CommissionsAndLeasesFileStruct.EjMes", "");
ssCuenta = r.ReadText(index++, "CommissionsAndLeasesFileStruct.Cuenta", "");
ssReferencia = r.ReadText(index++, "CommissionsAndLeasesFileStruct.Referencia", "");
ssNombre1 = r.ReadText(index++, "CommissionsAndLeasesFileStruct.Nombre1", "");
ssNombre2 = r.ReadText(index++, "CommissionsAndLeasesFileStruct.Nombre2", "");
ssNDoc = r.ReadText(index++, "CommissionsAndLeasesFileStruct.NDoc", "");
ssImporteEnML = r.ReadText(index++, "CommissionsAndLeasesFileStruct.ImporteEnML", "");
ssML = r.ReadText(index++, "CommissionsAndLeasesFileStruct.ML", "");
ssImporteEnMD = r.ReadText(index++, "CommissionsAndLeasesFileStruct.ImporteEnMD", "");
ssMon = r.ReadText(index++, "CommissionsAndLeasesFileStruct.Mon", "");
ssSoc = r.ReadText(index++, "CommissionsAndLeasesFileStruct.Soc", "");
ssDiv = r.ReadText(index++, "CommissionsAndLeasesFileStruct.Div", "");
ssLibMayor = r.ReadText(index++, "CommissionsAndLeasesFileStruct.LibMayor", "");
ssTextoCabDocumento = r.ReadText(index++, "CommissionsAndLeasesFileStruct.TextoCabDocumento", "");
ssDocComp = r.ReadText(index++, "CommissionsAndLeasesFileStruct.DocComp", "");
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_0a2958ff44247d7464fd88ba7a80597cStructure r) {
this = r;
}


public static bool operator == (ST_0a2958ff44247d7464fd88ba7a80597cStructure a, ST_0a2958ff44247d7464fd88ba7a80597cStructure b) {
if (a.ssFeContab != b.ssFeContab) return false;
if (a.ssEjMes != b.ssEjMes) return false;
if (a.ssCuenta != b.ssCuenta) return false;
if (a.ssReferencia != b.ssReferencia) return false;
if (a.ssNombre1 != b.ssNombre1) return false;
if (a.ssNombre2 != b.ssNombre2) return false;
if (a.ssNDoc != b.ssNDoc) return false;
if (a.ssImporteEnML != b.ssImporteEnML) return false;
if (a.ssML != b.ssML) return false;
if (a.ssImporteEnMD != b.ssImporteEnMD) return false;
if (a.ssMon != b.ssMon) return false;
if (a.ssSoc != b.ssSoc) return false;
if (a.ssDiv != b.ssDiv) return false;
if (a.ssLibMayor != b.ssLibMayor) return false;
if (a.ssTextoCabDocumento != b.ssTextoCabDocumento) return false;
if (a.ssDocComp != b.ssDocComp) return false;
return true;
}

public static bool operator != (ST_0a2958ff44247d7464fd88ba7a80597cStructure a, ST_0a2958ff44247d7464fd88ba7a80597cStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_0a2958ff44247d7464fd88ba7a80597cStructure)) return false;
return (this == (ST_0a2958ff44247d7464fd88ba7a80597cStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssFeContab.GetHashCode()
 ^ ssEjMes.GetHashCode()
 ^ ssCuenta.GetHashCode()
 ^ ssReferencia.GetHashCode()
 ^ ssNombre1.GetHashCode()
 ^ ssNombre2.GetHashCode()
 ^ ssNDoc.GetHashCode()
 ^ ssImporteEnML.GetHashCode()
 ^ ssML.GetHashCode()
 ^ ssImporteEnMD.GetHashCode()
 ^ ssMon.GetHashCode()
 ^ ssSoc.GetHashCode()
 ^ ssDiv.GetHashCode()
 ^ ssLibMayor.GetHashCode()
 ^ ssTextoCabDocumento.GetHashCode()
 ^ ssDocComp.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_0a2958ff44247d7464fd88ba7a80597cStructure Duplicate() {
ST_0a2958ff44247d7464fd88ba7a80597cStructure t;
t.ssFeContab = this.ssFeContab;
t.ssEjMes = this.ssEjMes;
t.ssCuenta = this.ssCuenta;
t.ssReferencia = this.ssReferencia;
t.ssNombre1 = this.ssNombre1;
t.ssNombre2 = this.ssNombre2;
t.ssNDoc = this.ssNDoc;
t.ssImporteEnML = this.ssImporteEnML;
t.ssML = this.ssML;
t.ssImporteEnMD = this.ssImporteEnMD;
t.ssMon = this.ssMon;
t.ssSoc = this.ssSoc;
t.ssDiv = this.ssDiv;
t.ssLibMayor = this.ssLibMayor;
t.ssTextoCabDocumento = this.ssTextoCabDocumento;
t.ssDocComp = this.ssDocComp;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "fecontab") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FeContab")) variable.Value = ssFeContab; else variable.Optimized = true;
} else if (head == "ejmes") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EjMes")) variable.Value = ssEjMes; else variable.Optimized = true;
} else if (head == "cuenta") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Cuenta")) variable.Value = ssCuenta; else variable.Optimized = true;
} else if (head == "referencia") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Referencia")) variable.Value = ssReferencia; else variable.Optimized = true;
} else if (head == "nombre1") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Nombre1")) variable.Value = ssNombre1; else variable.Optimized = true;
} else if (head == "nombre2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Nombre2")) variable.Value = ssNombre2; else variable.Optimized = true;
} else if (head == "ndoc") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NDoc")) variable.Value = ssNDoc; else variable.Optimized = true;
} else if (head == "importeenml") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ImporteEnML")) variable.Value = ssImporteEnML; else variable.Optimized = true;
} else if (head == "ml") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ML")) variable.Value = ssML; else variable.Optimized = true;
} else if (head == "importeenmd") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ImporteEnMD")) variable.Value = ssImporteEnMD; else variable.Optimized = true;
} else if (head == "mon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Mon")) variable.Value = ssMon; else variable.Optimized = true;
} else if (head == "soc") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Soc")) variable.Value = ssSoc; else variable.Optimized = true;
} else if (head == "div") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Div")) variable.Value = ssDiv; else variable.Optimized = true;
} else if (head == "libmayor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LibMayor")) variable.Value = ssLibMayor; else variable.Optimized = true;
} else if (head == "textocabdocumento") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TextoCabDocumento")) variable.Value = ssTextoCabDocumento; else variable.Optimized = true;
} else if (head == "doccomp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocComp")) variable.Value = ssDocComp; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFeContab) {
return ssFeContab;
}
if (key == IdEjMes) {
return ssEjMes;
}
if (key == IdCuenta) {
return ssCuenta;
}
if (key == IdReferencia) {
return ssReferencia;
}
if (key == IdNombre1) {
return ssNombre1;
}
if (key == IdNombre2) {
return ssNombre2;
}
if (key == IdNDoc) {
return ssNDoc;
}
if (key == IdImporteEnML) {
return ssImporteEnML;
}
if (key == IdML) {
return ssML;
}
if (key == IdImporteEnMD) {
return ssImporteEnMD;
}
if (key == IdMon) {
return ssMon;
}
if (key == IdSoc) {
return ssSoc;
}
if (key == IdDiv) {
return ssDiv;
}
if (key == IdLibMayor) {
return ssLibMayor;
}
if (key == IdTextoCabDocumento) {
return ssTextoCabDocumento;
}
if (key == IdDocComp) {
return ssDocComp;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFeContab.Key.AsGuid) {
return ssFeContab;
}
if (attributeKey == IdEjMes.Key.AsGuid) {
return ssEjMes;
}
if (attributeKey == IdCuenta.Key.AsGuid) {
return ssCuenta;
}
if (attributeKey == IdReferencia.Key.AsGuid) {
return ssReferencia;
}
if (attributeKey == IdNombre1.Key.AsGuid) {
return ssNombre1;
}
if (attributeKey == IdNombre2.Key.AsGuid) {
return ssNombre2;
}
if (attributeKey == IdNDoc.Key.AsGuid) {
return ssNDoc;
}
if (attributeKey == IdImporteEnML.Key.AsGuid) {
return ssImporteEnML;
}
if (attributeKey == IdML.Key.AsGuid) {
return ssML;
}
if (attributeKey == IdImporteEnMD.Key.AsGuid) {
return ssImporteEnMD;
}
if (attributeKey == IdMon.Key.AsGuid) {
return ssMon;
}
if (attributeKey == IdSoc.Key.AsGuid) {
return ssSoc;
}
if (attributeKey == IdDiv.Key.AsGuid) {
return ssDiv;
}
if (attributeKey == IdLibMayor.Key.AsGuid) {
return ssLibMayor;
}
if (attributeKey == IdTextoCabDocumento.Key.AsGuid) {
return ssTextoCabDocumento;
}
if (attributeKey == IdDocComp.Key.AsGuid) {
return ssDocComp;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssFeContab = (string) other.AttributeGet(IdFeContab);
ssEjMes = (string) other.AttributeGet(IdEjMes);
ssCuenta = (string) other.AttributeGet(IdCuenta);
ssReferencia = (string) other.AttributeGet(IdReferencia);
ssNombre1 = (string) other.AttributeGet(IdNombre1);
ssNombre2 = (string) other.AttributeGet(IdNombre2);
ssNDoc = (string) other.AttributeGet(IdNDoc);
ssImporteEnML = (string) other.AttributeGet(IdImporteEnML);
ssML = (string) other.AttributeGet(IdML);
ssImporteEnMD = (string) other.AttributeGet(IdImporteEnMD);
ssMon = (string) other.AttributeGet(IdMon);
ssSoc = (string) other.AttributeGet(IdSoc);
ssDiv = (string) other.AttributeGet(IdDiv);
ssLibMayor = (string) other.AttributeGet(IdLibMayor);
ssTextoCabDocumento = (string) other.AttributeGet(IdTextoCabDocumento);
ssDocComp = (string) other.AttributeGet(IdDocComp);
}
} // ST_0a2958ff44247d7464fd88ba7a80597cStructure
/// <summary>
/// RecordList type <code>CommissionsAndLeasesFileStructList</code> that represents a record list of
///  <code>CommissionsAndLeasesFileStruct</code>
/// </summary>
public partial class RL_238f83286c67570510312c00ff7c1c1b : GenericRecordList<ST_0a2958ff44247d7464fd88ba7a80597cStructure>, IEnumerable, IEnumerator {

protected override ST_0a2958ff44247d7464fd88ba7a80597cStructure GetElementDefaultValue() {
return new ST_0a2958ff44247d7464fd88ba7a80597cStructure();
}

public T[] ToArray<T>(Func<ST_0a2958ff44247d7464fd88ba7a80597cStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_238f83286c67570510312c00ff7c1c1b recordList, Func<ST_0a2958ff44247d7464fd88ba7a80597cStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_238f83286c67570510312c00ff7c1c1b(ST_0a2958ff44247d7464fd88ba7a80597cStructure[] array) {
  RL_238f83286c67570510312c00ff7c1c1b result = new RL_238f83286c67570510312c00ff7c1c1b();
result.InnerFromArray(array);
    return result;
}

public static RL_238f83286c67570510312c00ff7c1c1b ToList<T>(T[] array, Func <T, ST_0a2958ff44247d7464fd88ba7a80597cStructure> converter) {
  RL_238f83286c67570510312c00ff7c1c1b result = new RL_238f83286c67570510312c00ff7c1c1b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_238f83286c67570510312c00ff7c1c1b FromRestList<T>(RestList<T> restList, Func <T, ST_0a2958ff44247d7464fd88ba7a80597cStructure> converter) {
  RL_238f83286c67570510312c00ff7c1c1b result = new RL_238f83286c67570510312c00ff7c1c1b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_238f83286c67570510312c00ff7c1c1b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_0a2958ff44247d7464fd88ba7a80597cStructure> NewList() {
return new RL_238f83286c67570510312c00ff7c1c1b();
}


} // RL_238f83286c67570510312c00ff7c1c1b
}

