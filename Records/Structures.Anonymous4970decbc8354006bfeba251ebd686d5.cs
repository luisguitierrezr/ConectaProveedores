namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (y95wSTXIBkC_66JR69aG1Q)
///  <code>RC_53bfb6ba3a8f9433f06f269f872b84c8</code> that represents <code>ManualUserAreaRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ManualUserAreaRecord
public partial struct RC_53bfb6ba3a8f9433f06f269f872b84c8 : ITypedRecord<RC_53bfb6ba3a8f9433f06f269f872b84c8> {
internal static readonly GlobalObjectKey IdManualUserArea = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ura_U486M5TwbyafhyuEyA");

public EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord ssENManualUserArea;


public static implicit operator EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord( RC_53bfb6ba3a8f9433f06f269f872b84c8 r) {
return r.ssENManualUserArea;
}

public static implicit operator RC_53bfb6ba3a8f9433f06f269f872b84c8 (EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord r) {
RC_53bfb6ba3a8f9433f06f269f872b84c8 res = new RC_53bfb6ba3a8f9433f06f269f872b84c8 ();
res.ssENManualUserArea = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENManualUserArea.ChangedAttributes = value;
}
get {
    return ssENManualUserArea.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_53bfb6ba3a8f9433f06f269f872b84c8() {
OptimizedAttributes = null;
ssENManualUserArea = new EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(3,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENManualUserArea.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENManualUserArea.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENManualUserArea.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENManualUserArea.Read( r, ref index);
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
public void ReadIM(RC_53bfb6ba3a8f9433f06f269f872b84c8 r) {
this = r;
}


public static bool operator == (RC_53bfb6ba3a8f9433f06f269f872b84c8 a, RC_53bfb6ba3a8f9433f06f269f872b84c8 b) {
if (a.ssENManualUserArea != b.ssENManualUserArea) return false;
return true;
}

public static bool operator != (RC_53bfb6ba3a8f9433f06f269f872b84c8 a, RC_53bfb6ba3a8f9433f06f269f872b84c8 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_53bfb6ba3a8f9433f06f269f872b84c8)) return false;
return (this == (RC_53bfb6ba3a8f9433f06f269f872b84c8)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENManualUserArea.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENManualUserArea.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENManualUserArea.InternalRecursiveSave();
}


public RC_53bfb6ba3a8f9433f06f269f872b84c8 Duplicate() {
RC_53bfb6ba3a8f9433f06f269f872b84c8 t;
t.ssENManualUserArea = (EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord)this.ssENManualUserArea.Duplicate();
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
if (head == "manualuserarea") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ManualUserArea")) variable.Value = ssENManualUserArea; else variable.Optimized = true;
variable.SetFieldName("manualuserarea");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENManualUserArea.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENManualUserArea.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdManualUserArea) {
return ssENManualUserArea;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdManualUserArea.Key.AsGuid) {
return ssENManualUserArea;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENManualUserArea.FillFromOther((IRecord) other.AttributeGet(IdManualUserArea));
}
} // RC_53bfb6ba3a8f9433f06f269f872b84c8
/// <summary>
/// RecordList type <code>ManualUserAreaRecordList</code> that represents a record list of
///  <code>ManualUserArea</code>
/// </summary>
public partial class RL_f8182e26b7db4cf0329b98274bcdad7c : GenericRecordList<RC_53bfb6ba3a8f9433f06f269f872b84c8>, IEnumerable, IEnumerator {

protected override RC_53bfb6ba3a8f9433f06f269f872b84c8 GetElementDefaultValue() {
return new RC_53bfb6ba3a8f9433f06f269f872b84c8();
}

public T[] ToArray<T>(Func<RC_53bfb6ba3a8f9433f06f269f872b84c8, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f8182e26b7db4cf0329b98274bcdad7c recordList, Func<RC_53bfb6ba3a8f9433f06f269f872b84c8, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f8182e26b7db4cf0329b98274bcdad7c(RC_53bfb6ba3a8f9433f06f269f872b84c8[] array) {
  RL_f8182e26b7db4cf0329b98274bcdad7c result = new RL_f8182e26b7db4cf0329b98274bcdad7c();
result.InnerFromArray(array);
    return result;
}

public static RL_f8182e26b7db4cf0329b98274bcdad7c ToList<T>(T[] array, Func <T, RC_53bfb6ba3a8f9433f06f269f872b84c8> converter) {
  RL_f8182e26b7db4cf0329b98274bcdad7c result = new RL_f8182e26b7db4cf0329b98274bcdad7c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f8182e26b7db4cf0329b98274bcdad7c FromRestList<T>(RestList<T> restList, Func <T, RC_53bfb6ba3a8f9433f06f269f872b84c8> converter) {
  RL_f8182e26b7db4cf0329b98274bcdad7c result = new RL_f8182e26b7db4cf0329b98274bcdad7c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f8182e26b7db4cf0329b98274bcdad7c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(3,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_53bfb6ba3a8f9433f06f269f872b84c8> NewList() {
return new RL_f8182e26b7db4cf0329b98274bcdad7c();
}


} // RL_f8182e26b7db4cf0329b98274bcdad7c
}

