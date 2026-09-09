namespace ssConectaProveedores {
/// <summary>
/// [Structure] FolioReject (BDTcPVKlhE+4YoK1rF1vxg)
///  <code>ST_e54bcdc56c6f092fdfed672ad024bfa4Structure</code> that represents <code>FolioReject</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioReject
public partial struct ST_e54bcdc56c6f092fdfed672ad024bfa4Structure : ITypedRecord<ST_e54bcdc56c6f092fdfed672ad024bfa4Structure> {
internal static readonly GlobalObjectKey IdIsCancelEntry = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_+S1l7GJ3EKEhLNGhcpZNA");
internal static readonly GlobalObjectKey IdIsCancelInvoice = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*lSMONNJMuEKhdG19MRQS5w");
internal static readonly GlobalObjectKey IdIsCancelFolio = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*w4qIXr4vG0qZDjiOOR7lgQ");
internal static readonly GlobalObjectKey IdIsRejectInvoice = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*NuBUAcHWi0SC+FPLgJpbog");
internal static readonly GlobalObjectKey IdReason = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*LZLePzfXbEOAxMUwEIfGqQ");

public bool ssIsCancelEntry;

public bool ssIsCancelInvoice;

public bool ssIsCancelFolio;

public bool ssIsRejectInvoice;

public string ssReason;


public BitArray OptimizedAttributes;

public ST_e54bcdc56c6f092fdfed672ad024bfa4Structure() {
OptimizedAttributes = null;
ssIsCancelEntry = false;
ssIsCancelInvoice = false;
ssIsCancelFolio = false;
ssIsRejectInvoice = false;
ssReason = "";
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
ssIsCancelEntry = r.ReadBoolean(index++, "FolioReject.IsCancelEntry", false);
ssIsCancelInvoice = r.ReadBoolean(index++, "FolioReject.IsCancelInvoice", false);
ssIsCancelFolio = r.ReadBoolean(index++, "FolioReject.IsCancelFolio", false);
ssIsRejectInvoice = r.ReadBoolean(index++, "FolioReject.IsRejectInvoice", false);
ssReason = r.ReadText(index++, "FolioReject.Reason", "");
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
public void ReadIM(ST_e54bcdc56c6f092fdfed672ad024bfa4Structure r) {
this = r;
}


public static bool operator == (ST_e54bcdc56c6f092fdfed672ad024bfa4Structure a, ST_e54bcdc56c6f092fdfed672ad024bfa4Structure b) {
if (a.ssIsCancelEntry != b.ssIsCancelEntry) return false;
if (a.ssIsCancelInvoice != b.ssIsCancelInvoice) return false;
if (a.ssIsCancelFolio != b.ssIsCancelFolio) return false;
if (a.ssIsRejectInvoice != b.ssIsRejectInvoice) return false;
if (a.ssReason != b.ssReason) return false;
return true;
}

public static bool operator != (ST_e54bcdc56c6f092fdfed672ad024bfa4Structure a, ST_e54bcdc56c6f092fdfed672ad024bfa4Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_e54bcdc56c6f092fdfed672ad024bfa4Structure)) return false;
return (this == (ST_e54bcdc56c6f092fdfed672ad024bfa4Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssIsCancelEntry.GetHashCode()
 ^ ssIsCancelInvoice.GetHashCode()
 ^ ssIsCancelFolio.GetHashCode()
 ^ ssIsRejectInvoice.GetHashCode()
 ^ ssReason.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_e54bcdc56c6f092fdfed672ad024bfa4Structure Duplicate() {
ST_e54bcdc56c6f092fdfed672ad024bfa4Structure t;
t.ssIsCancelEntry = this.ssIsCancelEntry;
t.ssIsCancelInvoice = this.ssIsCancelInvoice;
t.ssIsCancelFolio = this.ssIsCancelFolio;
t.ssIsRejectInvoice = this.ssIsRejectInvoice;
t.ssReason = this.ssReason;
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
if (head == "iscancelentry") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsCancelEntry")) variable.Value = ssIsCancelEntry; else variable.Optimized = true;
} else if (head == "iscancelinvoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsCancelInvoice")) variable.Value = ssIsCancelInvoice; else variable.Optimized = true;
} else if (head == "iscancelfolio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsCancelFolio")) variable.Value = ssIsCancelFolio; else variable.Optimized = true;
} else if (head == "isrejectinvoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsRejectInvoice")) variable.Value = ssIsRejectInvoice; else variable.Optimized = true;
} else if (head == "reason") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Reason")) variable.Value = ssReason; else variable.Optimized = true;
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
if (key == IdIsCancelEntry) {
return ssIsCancelEntry;
}
if (key == IdIsCancelInvoice) {
return ssIsCancelInvoice;
}
if (key == IdIsCancelFolio) {
return ssIsCancelFolio;
}
if (key == IdIsRejectInvoice) {
return ssIsRejectInvoice;
}
if (key == IdReason) {
return ssReason;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdIsCancelEntry.Key.AsGuid) {
return ssIsCancelEntry;
}
if (attributeKey == IdIsCancelInvoice.Key.AsGuid) {
return ssIsCancelInvoice;
}
if (attributeKey == IdIsCancelFolio.Key.AsGuid) {
return ssIsCancelFolio;
}
if (attributeKey == IdIsRejectInvoice.Key.AsGuid) {
return ssIsRejectInvoice;
}
if (attributeKey == IdReason.Key.AsGuid) {
return ssReason;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssIsCancelEntry = (bool) other.AttributeGet(IdIsCancelEntry);
ssIsCancelInvoice = (bool) other.AttributeGet(IdIsCancelInvoice);
ssIsCancelFolio = (bool) other.AttributeGet(IdIsCancelFolio);
ssIsRejectInvoice = (bool) other.AttributeGet(IdIsRejectInvoice);
ssReason = (string) other.AttributeGet(IdReason);
}
} // ST_e54bcdc56c6f092fdfed672ad024bfa4Structure
/// <summary>
/// RecordList type <code>FolioRejectList</code> that represents a record list of
///  <code>FolioReject</code>
/// </summary>
public partial class RL_4dd965842b5b7eff5eeced09dfda5923 : GenericRecordList<ST_e54bcdc56c6f092fdfed672ad024bfa4Structure>, IEnumerable, IEnumerator {

protected override ST_e54bcdc56c6f092fdfed672ad024bfa4Structure GetElementDefaultValue() {
return new ST_e54bcdc56c6f092fdfed672ad024bfa4Structure();
}

public T[] ToArray<T>(Func<ST_e54bcdc56c6f092fdfed672ad024bfa4Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4dd965842b5b7eff5eeced09dfda5923 recordList, Func<ST_e54bcdc56c6f092fdfed672ad024bfa4Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4dd965842b5b7eff5eeced09dfda5923(ST_e54bcdc56c6f092fdfed672ad024bfa4Structure[] array) {
  RL_4dd965842b5b7eff5eeced09dfda5923 result = new RL_4dd965842b5b7eff5eeced09dfda5923();
result.InnerFromArray(array);
    return result;
}

public static RL_4dd965842b5b7eff5eeced09dfda5923 ToList<T>(T[] array, Func <T, ST_e54bcdc56c6f092fdfed672ad024bfa4Structure> converter) {
  RL_4dd965842b5b7eff5eeced09dfda5923 result = new RL_4dd965842b5b7eff5eeced09dfda5923();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4dd965842b5b7eff5eeced09dfda5923 FromRestList<T>(RestList<T> restList, Func <T, ST_e54bcdc56c6f092fdfed672ad024bfa4Structure> converter) {
  RL_4dd965842b5b7eff5eeced09dfda5923 result = new RL_4dd965842b5b7eff5eeced09dfda5923();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4dd965842b5b7eff5eeced09dfda5923() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_e54bcdc56c6f092fdfed672ad024bfa4Structure> NewList() {
return new RL_4dd965842b5b7eff5eeced09dfda5923();
}


} // RL_4dd965842b5b7eff5eeced09dfda5923
}

