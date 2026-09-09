namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (is78kR5h4kO1rBBr9Fi6qw)
///  <code>RC_e03a49308bfaca02257d451178bbf041</code> that represents <code>DropdownOptionRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: DropdownOptionRecord
public partial struct RC_e03a49308bfaca02257d451178bbf041 : ITypedRecord<RC_e03a49308bfaca02257d451178bbf041> {
internal static readonly GlobalObjectKey IdDropdownOption = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*MEk64PqLAsolfUUReLvwQQ");

public ST_60f22bd2e9b10a22278b8afe6d7f601aStructure ssSTDropdownOption;


public static implicit operator ST_60f22bd2e9b10a22278b8afe6d7f601aStructure( RC_e03a49308bfaca02257d451178bbf041 r) {
return r.ssSTDropdownOption;
}

public static implicit operator RC_e03a49308bfaca02257d451178bbf041 (ST_60f22bd2e9b10a22278b8afe6d7f601aStructure r) {
RC_e03a49308bfaca02257d451178bbf041 res = new RC_e03a49308bfaca02257d451178bbf041 ();
res.ssSTDropdownOption = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_e03a49308bfaca02257d451178bbf041() {
OptimizedAttributes = null;
ssSTDropdownOption = new ST_60f22bd2e9b10a22278b8afe6d7f601aStructure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTDropdownOption.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTDropdownOption.Read( r, ref index);
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
public void ReadIM(RC_e03a49308bfaca02257d451178bbf041 r) {
this = r;
}


public static bool operator == (RC_e03a49308bfaca02257d451178bbf041 a, RC_e03a49308bfaca02257d451178bbf041 b) {
if (a.ssSTDropdownOption != b.ssSTDropdownOption) return false;
return true;
}

public static bool operator != (RC_e03a49308bfaca02257d451178bbf041 a, RC_e03a49308bfaca02257d451178bbf041 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e03a49308bfaca02257d451178bbf041)) return false;
return (this == (RC_e03a49308bfaca02257d451178bbf041)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDropdownOption.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDropdownOption.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDropdownOption.InternalRecursiveSave();
}


public RC_e03a49308bfaca02257d451178bbf041 Duplicate() {
RC_e03a49308bfaca02257d451178bbf041 t;
t.ssSTDropdownOption = (ST_60f22bd2e9b10a22278b8afe6d7f601aStructure)this.ssSTDropdownOption.Duplicate();
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
if (head == "dropdownoption") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DropdownOption")) variable.Value = ssSTDropdownOption; else variable.Optimized = true;
variable.SetFieldName("dropdownoption");
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
if (key == IdDropdownOption) {
return ssSTDropdownOption;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDropdownOption.Key.AsGuid) {
return ssSTDropdownOption;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDropdownOption.FillFromOther((IRecord) other.AttributeGet(IdDropdownOption));
}
} // RC_e03a49308bfaca02257d451178bbf041
/// <summary>
/// RecordList type <code>DropdownOptionRecordList</code> that represents a record list of
///  <code>DropdownOption</code>
/// </summary>
public partial class RL_b17522b541f7e019c0443ba6658c825f : GenericRecordList<RC_e03a49308bfaca02257d451178bbf041>, IEnumerable, IEnumerator {

protected override RC_e03a49308bfaca02257d451178bbf041 GetElementDefaultValue() {
return new RC_e03a49308bfaca02257d451178bbf041();
}

public T[] ToArray<T>(Func<RC_e03a49308bfaca02257d451178bbf041, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b17522b541f7e019c0443ba6658c825f recordList, Func<RC_e03a49308bfaca02257d451178bbf041, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b17522b541f7e019c0443ba6658c825f(RC_e03a49308bfaca02257d451178bbf041[] array) {
  RL_b17522b541f7e019c0443ba6658c825f result = new RL_b17522b541f7e019c0443ba6658c825f();
result.InnerFromArray(array);
    return result;
}

public static RL_b17522b541f7e019c0443ba6658c825f ToList<T>(T[] array, Func <T, RC_e03a49308bfaca02257d451178bbf041> converter) {
  RL_b17522b541f7e019c0443ba6658c825f result = new RL_b17522b541f7e019c0443ba6658c825f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b17522b541f7e019c0443ba6658c825f FromRestList<T>(RestList<T> restList, Func <T, RC_e03a49308bfaca02257d451178bbf041> converter) {
  RL_b17522b541f7e019c0443ba6658c825f result = new RL_b17522b541f7e019c0443ba6658c825f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b17522b541f7e019c0443ba6658c825f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_e03a49308bfaca02257d451178bbf041> NewList() {
return new RL_b17522b541f7e019c0443ba6658c825f();
}


} // RL_b17522b541f7e019c0443ba6658c825f
}

