namespace ssConectaProveedores {
/// <summary>
/// [Structure] ExcelFolioLogToExport (ndXXFm+MW02h4ss10nJTPw)
///  <code>ST_2e562a380f69a76cb54ade40213e888fStructure</code> that represent
/// s <code>ExcelFolioLogToExport</code> <p>Description: Excel Log To Export Struct.</p>
/// </summary>
// Name: ExcelFolioLogToExport
public partial struct ST_2e562a380f69a76cb54ade40213e888fStructure : ITypedRecord<ST_2e562a380f69a76cb54ade40213e888fStructure> {
internal static readonly GlobalObjectKey IdNumerodefolio = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8opmWHHavUqPy9PdNDIc1A");
internal static readonly GlobalObjectKey IdCreadopor = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Ly6OgAelW0+6tluTQ4gESQ");
internal static readonly GlobalObjectKey IdCreadoel = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*sTLsXypDe0OU5nfnvoruXA");
internal static readonly GlobalObjectKey IdMensaje = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1852RlHtbESaxQfpgh1Ftw");

public string ssNumerodefolio;

public string ssCreadopor;

public DateTime ssCreadoel;

public string ssMensaje;


public BitArray OptimizedAttributes;

public ST_2e562a380f69a76cb54ade40213e888fStructure() {
OptimizedAttributes = null;
ssNumerodefolio = "";
ssCreadopor = "";
ssCreadoel = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssMensaje = "";
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
ssNumerodefolio = r.ReadText(index++, "ExcelFolioLogToExport.Numerodefolio", "");
ssCreadopor = r.ReadText(index++, "ExcelFolioLogToExport.Creadopor", "");
ssCreadoel = r.ReadDateTime(index++, "ExcelFolioLogToExport.Creadoel", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssMensaje = r.ReadText(index++, "ExcelFolioLogToExport.Mensaje", "");
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
public void ReadIM(ST_2e562a380f69a76cb54ade40213e888fStructure r) {
this = r;
}


public static bool operator == (ST_2e562a380f69a76cb54ade40213e888fStructure a, ST_2e562a380f69a76cb54ade40213e888fStructure b) {
if (a.ssNumerodefolio != b.ssNumerodefolio) return false;
if (a.ssCreadopor != b.ssCreadopor) return false;
if (a.ssCreadoel != b.ssCreadoel) return false;
if (a.ssMensaje != b.ssMensaje) return false;
return true;
}

public static bool operator != (ST_2e562a380f69a76cb54ade40213e888fStructure a, ST_2e562a380f69a76cb54ade40213e888fStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_2e562a380f69a76cb54ade40213e888fStructure)) return false;
return (this == (ST_2e562a380f69a76cb54ade40213e888fStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssNumerodefolio.GetHashCode()
 ^ ssCreadopor.GetHashCode()
 ^ ssCreadoel.GetHashCode()
 ^ ssMensaje.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_2e562a380f69a76cb54ade40213e888fStructure Duplicate() {
ST_2e562a380f69a76cb54ade40213e888fStructure t;
t.ssNumerodefolio = this.ssNumerodefolio;
t.ssCreadopor = this.ssCreadopor;
t.ssCreadoel = this.ssCreadoel;
t.ssMensaje = this.ssMensaje;
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
if (head == "numerodefolio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Numerodefolio")) variable.Value = ssNumerodefolio; else variable.Optimized = true;
} else if (head == "creadopor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Creadopor")) variable.Value = ssCreadopor; else variable.Optimized = true;
} else if (head == "creadoel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Creadoel")) variable.Value = ssCreadoel; else variable.Optimized = true;
} else if (head == "mensaje") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Mensaje")) variable.Value = ssMensaje; else variable.Optimized = true;
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
if (key == IdNumerodefolio) {
return ssNumerodefolio;
}
if (key == IdCreadopor) {
return ssCreadopor;
}
if (key == IdCreadoel) {
return ssCreadoel;
}
if (key == IdMensaje) {
return ssMensaje;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdNumerodefolio.Key.AsGuid) {
return ssNumerodefolio;
}
if (attributeKey == IdCreadopor.Key.AsGuid) {
return ssCreadopor;
}
if (attributeKey == IdCreadoel.Key.AsGuid) {
return ssCreadoel;
}
if (attributeKey == IdMensaje.Key.AsGuid) {
return ssMensaje;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssNumerodefolio = (string) other.AttributeGet(IdNumerodefolio);
ssCreadopor = (string) other.AttributeGet(IdCreadopor);
ssCreadoel = (DateTime) other.AttributeGet(IdCreadoel);
ssMensaje = (string) other.AttributeGet(IdMensaje);
}
} // ST_2e562a380f69a76cb54ade40213e888fStructure
/// <summary>
/// RecordList type <code>ExcelFolioLogToExportList</code> that represents a record list of
///  <code>ExcelFolioLogToExport</code>
/// </summary>
public partial class RL_dc4d95fbd0db63ac62ca0dfbd88665dd : GenericRecordList<ST_2e562a380f69a76cb54ade40213e888fStructure>, IEnumerable, IEnumerator {

protected override ST_2e562a380f69a76cb54ade40213e888fStructure GetElementDefaultValue() {
return new ST_2e562a380f69a76cb54ade40213e888fStructure();
}

public T[] ToArray<T>(Func<ST_2e562a380f69a76cb54ade40213e888fStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_dc4d95fbd0db63ac62ca0dfbd88665dd recordList, Func<ST_2e562a380f69a76cb54ade40213e888fStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_dc4d95fbd0db63ac62ca0dfbd88665dd(ST_2e562a380f69a76cb54ade40213e888fStructure[] array) {
  RL_dc4d95fbd0db63ac62ca0dfbd88665dd result = new RL_dc4d95fbd0db63ac62ca0dfbd88665dd();
result.InnerFromArray(array);
    return result;
}

public static RL_dc4d95fbd0db63ac62ca0dfbd88665dd ToList<T>(T[] array, Func <T, ST_2e562a380f69a76cb54ade40213e888fStructure> converter) {
  RL_dc4d95fbd0db63ac62ca0dfbd88665dd result = new RL_dc4d95fbd0db63ac62ca0dfbd88665dd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_dc4d95fbd0db63ac62ca0dfbd88665dd FromRestList<T>(RestList<T> restList, Func <T, ST_2e562a380f69a76cb54ade40213e888fStructure> converter) {
  RL_dc4d95fbd0db63ac62ca0dfbd88665dd result = new RL_dc4d95fbd0db63ac62ca0dfbd88665dd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_dc4d95fbd0db63ac62ca0dfbd88665dd() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_2e562a380f69a76cb54ade40213e888fStructure> NewList() {
return new RL_dc4d95fbd0db63ac62ca0dfbd88665dd();
}


} // RL_dc4d95fbd0db63ac62ca0dfbd88665dd
}

