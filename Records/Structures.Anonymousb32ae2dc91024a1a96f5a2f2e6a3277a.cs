namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (3OIqswKRGkqW9aLy5qMneg)
///  <code>RC_73cba58e096fd5aef16244a229132919</code> that represents <code>ImportStatusRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ImportStatusRecord
public partial struct RC_73cba58e096fd5aef16244a229132919 : ITypedRecord<RC_73cba58e096fd5aef16244a229132919> {
internal static readonly GlobalObjectKey IdImportStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jqXLc28JrtXxYkSiKRMpGQ");

public EN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord ssENImportStatus;


public static implicit operator EN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord( RC_73cba58e096fd5aef16244a229132919 r) {
return r.ssENImportStatus;
}

public static implicit operator RC_73cba58e096fd5aef16244a229132919 (EN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord r) {
RC_73cba58e096fd5aef16244a229132919 res = new RC_73cba58e096fd5aef16244a229132919 ();
res.ssENImportStatus = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENImportStatus.ChangedAttributes = value;
}
get {
    return ssENImportStatus.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_73cba58e096fd5aef16244a229132919() {
OptimizedAttributes = null;
ssENImportStatus = new EN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENImportStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENImportStatus.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENImportStatus.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENImportStatus.Read( r, ref index);
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
public void ReadIM(RC_73cba58e096fd5aef16244a229132919 r) {
this = r;
}


public static bool operator == (RC_73cba58e096fd5aef16244a229132919 a, RC_73cba58e096fd5aef16244a229132919 b) {
if (a.ssENImportStatus != b.ssENImportStatus) return false;
return true;
}

public static bool operator != (RC_73cba58e096fd5aef16244a229132919 a, RC_73cba58e096fd5aef16244a229132919 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_73cba58e096fd5aef16244a229132919)) return false;
return (this == (RC_73cba58e096fd5aef16244a229132919)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENImportStatus.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENImportStatus.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENImportStatus.InternalRecursiveSave();
}


public RC_73cba58e096fd5aef16244a229132919 Duplicate() {
RC_73cba58e096fd5aef16244a229132919 t;
t.ssENImportStatus = (EN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord)this.ssENImportStatus.Duplicate();
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
if (head == "importstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ImportStatus")) variable.Value = ssENImportStatus; else variable.Optimized = true;
variable.SetFieldName("importstatus");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENImportStatus.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENImportStatus.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdImportStatus) {
return ssENImportStatus;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdImportStatus.Key.AsGuid) {
return ssENImportStatus;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENImportStatus.FillFromOther((IRecord) other.AttributeGet(IdImportStatus));
}
} // RC_73cba58e096fd5aef16244a229132919
/// <summary>
/// RecordList type <code>ImportStatusRecordList</code> that represents a record list of
///  <code>ImportStatus</code>
/// </summary>
public partial class RL_f2e3bbc17bbf31332e49e2b502d83a6c : GenericRecordList<RC_73cba58e096fd5aef16244a229132919>, IEnumerable, IEnumerator {

protected override RC_73cba58e096fd5aef16244a229132919 GetElementDefaultValue() {
return new RC_73cba58e096fd5aef16244a229132919();
}

public T[] ToArray<T>(Func<RC_73cba58e096fd5aef16244a229132919, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f2e3bbc17bbf31332e49e2b502d83a6c recordList, Func<RC_73cba58e096fd5aef16244a229132919, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f2e3bbc17bbf31332e49e2b502d83a6c(RC_73cba58e096fd5aef16244a229132919[] array) {
  RL_f2e3bbc17bbf31332e49e2b502d83a6c result = new RL_f2e3bbc17bbf31332e49e2b502d83a6c();
result.InnerFromArray(array);
    return result;
}

public static RL_f2e3bbc17bbf31332e49e2b502d83a6c ToList<T>(T[] array, Func <T, RC_73cba58e096fd5aef16244a229132919> converter) {
  RL_f2e3bbc17bbf31332e49e2b502d83a6c result = new RL_f2e3bbc17bbf31332e49e2b502d83a6c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f2e3bbc17bbf31332e49e2b502d83a6c FromRestList<T>(RestList<T> restList, Func <T, RC_73cba58e096fd5aef16244a229132919> converter) {
  RL_f2e3bbc17bbf31332e49e2b502d83a6c result = new RL_f2e3bbc17bbf31332e49e2b502d83a6c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f2e3bbc17bbf31332e49e2b502d83a6c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_73cba58e096fd5aef16244a229132919> NewList() {
return new RL_f2e3bbc17bbf31332e49e2b502d83a6c();
}


} // RL_f2e3bbc17bbf31332e49e2b502d83a6c
}

