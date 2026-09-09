namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (jy65OGlMHkSbEED_lw+zDw)
///  <code>RC_a2486f07cac8ccfda7e3d2f4c629f5d4</code> that represents <code>ReturnRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ReturnRecord
public partial struct RC_a2486f07cac8ccfda7e3d2f4c629f5d4 : ITypedRecord<RC_a2486f07cac8ccfda7e3d2f4c629f5d4> {
internal static readonly GlobalObjectKey IdReturn = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*B29IosjK_cyn49L0xin11A");

public ST_b1b6df219277397c7c2be747d587880aStructure ssSTReturn;


public static implicit operator ST_b1b6df219277397c7c2be747d587880aStructure( RC_a2486f07cac8ccfda7e3d2f4c629f5d4 r) {
return r.ssSTReturn;
}

public static implicit operator RC_a2486f07cac8ccfda7e3d2f4c629f5d4 (ST_b1b6df219277397c7c2be747d587880aStructure r) {
RC_a2486f07cac8ccfda7e3d2f4c629f5d4 res = new RC_a2486f07cac8ccfda7e3d2f4c629f5d4 ();
res.ssSTReturn = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_a2486f07cac8ccfda7e3d2f4c629f5d4() {
OptimizedAttributes = null;
ssSTReturn = new ST_b1b6df219277397c7c2be747d587880aStructure();
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
    ssSTReturn.OptimizedAttributes = value[0];
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
ssSTReturn.Read( r, ref index);
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
public void ReadIM(RC_a2486f07cac8ccfda7e3d2f4c629f5d4 r) {
this = r;
}


public static bool operator == (RC_a2486f07cac8ccfda7e3d2f4c629f5d4 a, RC_a2486f07cac8ccfda7e3d2f4c629f5d4 b) {
if (a.ssSTReturn != b.ssSTReturn) return false;
return true;
}

public static bool operator != (RC_a2486f07cac8ccfda7e3d2f4c629f5d4 a, RC_a2486f07cac8ccfda7e3d2f4c629f5d4 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a2486f07cac8ccfda7e3d2f4c629f5d4)) return false;
return (this == (RC_a2486f07cac8ccfda7e3d2f4c629f5d4)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTReturn.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTReturn.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTReturn.InternalRecursiveSave();
}


public RC_a2486f07cac8ccfda7e3d2f4c629f5d4 Duplicate() {
RC_a2486f07cac8ccfda7e3d2f4c629f5d4 t;
t.ssSTReturn = (ST_b1b6df219277397c7c2be747d587880aStructure)this.ssSTReturn.Duplicate();
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
if (head == "return") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Return")) variable.Value = ssSTReturn; else variable.Optimized = true;
variable.SetFieldName("return");
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
if (key == IdReturn) {
return ssSTReturn;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdReturn.Key.AsGuid) {
return ssSTReturn;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTReturn.FillFromOther((IRecord) other.AttributeGet(IdReturn));
}
} // RC_a2486f07cac8ccfda7e3d2f4c629f5d4
/// <summary>
/// RecordList type <code>ReturnRecordList</code> that represents a record list of <code>Return</code>
/// </summary>
public partial class RL_e3e7efec9fed90859222625eac44effa : GenericRecordList<RC_a2486f07cac8ccfda7e3d2f4c629f5d4>, IEnumerable, IEnumerator {

protected override RC_a2486f07cac8ccfda7e3d2f4c629f5d4 GetElementDefaultValue() {
return new RC_a2486f07cac8ccfda7e3d2f4c629f5d4();
}

public T[] ToArray<T>(Func<RC_a2486f07cac8ccfda7e3d2f4c629f5d4, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e3e7efec9fed90859222625eac44effa recordList, Func<RC_a2486f07cac8ccfda7e3d2f4c629f5d4, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e3e7efec9fed90859222625eac44effa(RC_a2486f07cac8ccfda7e3d2f4c629f5d4[] array) {
  RL_e3e7efec9fed90859222625eac44effa result = new RL_e3e7efec9fed90859222625eac44effa();
result.InnerFromArray(array);
    return result;
}

public static RL_e3e7efec9fed90859222625eac44effa ToList<T>(T[] array, Func <T, RC_a2486f07cac8ccfda7e3d2f4c629f5d4> converter) {
  RL_e3e7efec9fed90859222625eac44effa result = new RL_e3e7efec9fed90859222625eac44effa();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e3e7efec9fed90859222625eac44effa FromRestList<T>(RestList<T> restList, Func <T, RC_a2486f07cac8ccfda7e3d2f4c629f5d4> converter) {
  RL_e3e7efec9fed90859222625eac44effa result = new RL_e3e7efec9fed90859222625eac44effa();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e3e7efec9fed90859222625eac44effa() : base() {
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
protected override OSList<RC_a2486f07cac8ccfda7e3d2f4c629f5d4> NewList() {
return new RL_e3e7efec9fed90859222625eac44effa();
}


} // RL_e3e7efec9fed90859222625eac44effa
}

