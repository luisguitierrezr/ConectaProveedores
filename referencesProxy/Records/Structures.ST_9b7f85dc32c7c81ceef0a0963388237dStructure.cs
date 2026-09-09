namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] PostCarganovimRequestWrapper (jamo_B0yl02SiyNpiBm3Mg)
///  <code>ST_9b7f85dc32c7c81ceef0a0963388237dStructure</code> that represent
/// s <code>PostCarganovimRequestWrapper</code> <p>Description: PostCarganovimRequestWrapper</p>
/// </summary>
// Name: PostCarganovimRequestWrapper
public partial struct ST_9b7f85dc32c7c81ceef0a0963388237dStructure : ITypedRecord<ST_9b7f85dc32c7c81ceef0a0963388237dStructure> {
internal static readonly GlobalObjectKey IdCfdFile = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*V2TKwdaockaHgr63EFBsEw");
internal static readonly GlobalObjectKey IdSociedad = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*xWp470_PxkmiF5YyfuJZ8g");
internal static readonly GlobalObjectKey IdCveProveedor = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*z8jykk6PF0aqjCQaliOFOA");
internal static readonly GlobalObjectKey IdFileName = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*kkyCON11hEKtzYnHiuEUlw");
internal static readonly GlobalObjectKey IdDocType = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*L5iltFJdt0mGCgeWufx8+w");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*Th+wlTK0XkS4qFLuCUr3Zw");

public string ssCfdFile;

public string ssSociedad;

public string ssCveProveedor;

public string ssFileName;

public string ssDocType;

public string ssRegion;


public BitArray OptimizedAttributes;

public ST_9b7f85dc32c7c81ceef0a0963388237dStructure() {
OptimizedAttributes = null;
ssCfdFile = "";
ssSociedad = "";
ssCveProveedor = "";
ssFileName = "";
ssDocType = "";
ssRegion = "";
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
ssCfdFile = r.ReadText(index++, "PostCarganovimRequestWrapper.CfdFile", "");
ssSociedad = r.ReadText(index++, "PostCarganovimRequestWrapper.Sociedad", "");
ssCveProveedor = r.ReadText(index++, "PostCarganovimRequestWrapper.CveProveedor", "");
ssFileName = r.ReadText(index++, "PostCarganovimRequestWrapper.FileName", "");
ssDocType = r.ReadText(index++, "PostCarganovimRequestWrapper.DocType", "");
ssRegion = r.ReadText(index++, "PostCarganovimRequestWrapper.Region", "");
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
public void ReadIM(ST_9b7f85dc32c7c81ceef0a0963388237dStructure r) {
this = r;
}


public static bool operator == (ST_9b7f85dc32c7c81ceef0a0963388237dStructure a, ST_9b7f85dc32c7c81ceef0a0963388237dStructure b) {
if (a.ssCfdFile != b.ssCfdFile) return false;
if (a.ssSociedad != b.ssSociedad) return false;
if (a.ssCveProveedor != b.ssCveProveedor) return false;
if (a.ssFileName != b.ssFileName) return false;
if (a.ssDocType != b.ssDocType) return false;
if (a.ssRegion != b.ssRegion) return false;
return true;
}

public static bool operator != (ST_9b7f85dc32c7c81ceef0a0963388237dStructure a, ST_9b7f85dc32c7c81ceef0a0963388237dStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_9b7f85dc32c7c81ceef0a0963388237dStructure)) return false;
return (this == (ST_9b7f85dc32c7c81ceef0a0963388237dStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssCfdFile.GetHashCode()
 ^ ssSociedad.GetHashCode()
 ^ ssCveProveedor.GetHashCode()
 ^ ssFileName.GetHashCode()
 ^ ssDocType.GetHashCode()
 ^ ssRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_9b7f85dc32c7c81ceef0a0963388237dStructure Duplicate() {
ST_9b7f85dc32c7c81ceef0a0963388237dStructure t;
t.ssCfdFile = this.ssCfdFile;
t.ssSociedad = this.ssSociedad;
t.ssCveProveedor = this.ssCveProveedor;
t.ssFileName = this.ssFileName;
t.ssDocType = this.ssDocType;
t.ssRegion = this.ssRegion;
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
if (head == "cfdfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CfdFile")) variable.Value = ssCfdFile; else variable.Optimized = true;
} else if (head == "sociedad") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Sociedad")) variable.Value = ssSociedad; else variable.Optimized = true;
} else if (head == "cveproveedor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CveProveedor")) variable.Value = ssCveProveedor; else variable.Optimized = true;
} else if (head == "filename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileName")) variable.Value = ssFileName; else variable.Optimized = true;
} else if (head == "doctype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocType")) variable.Value = ssDocType; else variable.Optimized = true;
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssRegion; else variable.Optimized = true;
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
if (key == IdCfdFile) {
return ssCfdFile;
}
if (key == IdSociedad) {
return ssSociedad;
}
if (key == IdCveProveedor) {
return ssCveProveedor;
}
if (key == IdFileName) {
return ssFileName;
}
if (key == IdDocType) {
return ssDocType;
}
if (key == IdRegion) {
return ssRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCfdFile.Key.AsGuid) {
return ssCfdFile;
}
if (attributeKey == IdSociedad.Key.AsGuid) {
return ssSociedad;
}
if (attributeKey == IdCveProveedor.Key.AsGuid) {
return ssCveProveedor;
}
if (attributeKey == IdFileName.Key.AsGuid) {
return ssFileName;
}
if (attributeKey == IdDocType.Key.AsGuid) {
return ssDocType;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssCfdFile = (string) other.AttributeGet(IdCfdFile);
ssSociedad = (string) other.AttributeGet(IdSociedad);
ssCveProveedor = (string) other.AttributeGet(IdCveProveedor);
ssFileName = (string) other.AttributeGet(IdFileName);
ssDocType = (string) other.AttributeGet(IdDocType);
ssRegion = (string) other.AttributeGet(IdRegion);
}
} // ST_9b7f85dc32c7c81ceef0a0963388237dStructure
/// <summary>
/// RecordList type <code>PostCarganovimRequestWrapperList</code> that represents a record list of
///  <code>PostCarganovimRequestWrapper</code>
/// </summary>
public partial class RL_89d63ba3364a5fedf577bcba8fbddfb3 : GenericRecordList<ST_9b7f85dc32c7c81ceef0a0963388237dStructure>, IEnumerable, IEnumerator {

protected override ST_9b7f85dc32c7c81ceef0a0963388237dStructure GetElementDefaultValue() {
return new ST_9b7f85dc32c7c81ceef0a0963388237dStructure();
}

public T[] ToArray<T>(Func<ST_9b7f85dc32c7c81ceef0a0963388237dStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_89d63ba3364a5fedf577bcba8fbddfb3 recordList, Func<ST_9b7f85dc32c7c81ceef0a0963388237dStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_89d63ba3364a5fedf577bcba8fbddfb3(ST_9b7f85dc32c7c81ceef0a0963388237dStructure[] array) {
  RL_89d63ba3364a5fedf577bcba8fbddfb3 result = new RL_89d63ba3364a5fedf577bcba8fbddfb3();
result.InnerFromArray(array);
    return result;
}

public static RL_89d63ba3364a5fedf577bcba8fbddfb3 ToList<T>(T[] array, Func <T, ST_9b7f85dc32c7c81ceef0a0963388237dStructure> converter) {
  RL_89d63ba3364a5fedf577bcba8fbddfb3 result = new RL_89d63ba3364a5fedf577bcba8fbddfb3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_89d63ba3364a5fedf577bcba8fbddfb3 FromRestList<T>(RestList<T> restList, Func <T, ST_9b7f85dc32c7c81ceef0a0963388237dStructure> converter) {
  RL_89d63ba3364a5fedf577bcba8fbddfb3 result = new RL_89d63ba3364a5fedf577bcba8fbddfb3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_89d63ba3364a5fedf577bcba8fbddfb3() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_9b7f85dc32c7c81ceef0a0963388237dStructure> NewList() {
return new RL_89d63ba3364a5fedf577bcba8fbddfb3();
}


} // RL_89d63ba3364a5fedf577bcba8fbddfb3
}

