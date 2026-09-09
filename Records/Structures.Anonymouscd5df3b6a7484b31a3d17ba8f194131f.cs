namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (tvNdzUinMUuj0Xuo8ZQTHw)
///  <code>RC_e1057cc576f9e6054c23318f5973b604</code> that represents <code>PI_ITEM_EM2Record</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_ITEM_EM2Record
public partial struct RC_e1057cc576f9e6054c23318f5973b604 : ITypedRecord<RC_e1057cc576f9e6054c23318f5973b604> {
internal static readonly GlobalObjectKey IdPI_ITEM_EM2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xXwF4fl2BeZMIzGPWXO2BA");

public ST_7dc1141edc6ff8164773775d2fc68a19Structure ssSTPI_ITEM_EM2;


public static implicit operator ST_7dc1141edc6ff8164773775d2fc68a19Structure( RC_e1057cc576f9e6054c23318f5973b604 r) {
return r.ssSTPI_ITEM_EM2;
}

public static implicit operator RC_e1057cc576f9e6054c23318f5973b604 (ST_7dc1141edc6ff8164773775d2fc68a19Structure r) {
RC_e1057cc576f9e6054c23318f5973b604 res = new RC_e1057cc576f9e6054c23318f5973b604 ();
res.ssSTPI_ITEM_EM2 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_e1057cc576f9e6054c23318f5973b604() {
OptimizedAttributes = null;
ssSTPI_ITEM_EM2 = new ST_7dc1141edc6ff8164773775d2fc68a19Structure();
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
    ssSTPI_ITEM_EM2.OptimizedAttributes = value[0];
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
ssSTPI_ITEM_EM2.Read( r, ref index);
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
public void ReadIM(RC_e1057cc576f9e6054c23318f5973b604 r) {
this = r;
}


public static bool operator == (RC_e1057cc576f9e6054c23318f5973b604 a, RC_e1057cc576f9e6054c23318f5973b604 b) {
if (a.ssSTPI_ITEM_EM2 != b.ssSTPI_ITEM_EM2) return false;
return true;
}

public static bool operator != (RC_e1057cc576f9e6054c23318f5973b604 a, RC_e1057cc576f9e6054c23318f5973b604 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e1057cc576f9e6054c23318f5973b604)) return false;
return (this == (RC_e1057cc576f9e6054c23318f5973b604)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPI_ITEM_EM2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPI_ITEM_EM2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPI_ITEM_EM2.InternalRecursiveSave();
}


public RC_e1057cc576f9e6054c23318f5973b604 Duplicate() {
RC_e1057cc576f9e6054c23318f5973b604 t;
t.ssSTPI_ITEM_EM2 = (ST_7dc1141edc6ff8164773775d2fc68a19Structure)this.ssSTPI_ITEM_EM2.Duplicate();
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
if (head == "pi_item_em2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ITEM_EM2")) variable.Value = ssSTPI_ITEM_EM2; else variable.Optimized = true;
variable.SetFieldName("pi_item_em2");
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
if (key == IdPI_ITEM_EM2) {
return ssSTPI_ITEM_EM2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_ITEM_EM2.Key.AsGuid) {
return ssSTPI_ITEM_EM2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPI_ITEM_EM2.FillFromOther((IRecord) other.AttributeGet(IdPI_ITEM_EM2));
}
} // RC_e1057cc576f9e6054c23318f5973b604
/// <summary>
/// RecordList type <code>PI_ITEM_EM2RecordList</code> that represents a record list of
///  <code>PI_ITEM_EM2</code>
/// </summary>
public partial class RL_698f7b78c94e286c7a57a5ca0a521f77 : GenericRecordList<RC_e1057cc576f9e6054c23318f5973b604>, IEnumerable, IEnumerator {

protected override RC_e1057cc576f9e6054c23318f5973b604 GetElementDefaultValue() {
return new RC_e1057cc576f9e6054c23318f5973b604();
}

public T[] ToArray<T>(Func<RC_e1057cc576f9e6054c23318f5973b604, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_698f7b78c94e286c7a57a5ca0a521f77 recordList, Func<RC_e1057cc576f9e6054c23318f5973b604, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_698f7b78c94e286c7a57a5ca0a521f77(RC_e1057cc576f9e6054c23318f5973b604[] array) {
  RL_698f7b78c94e286c7a57a5ca0a521f77 result = new RL_698f7b78c94e286c7a57a5ca0a521f77();
result.InnerFromArray(array);
    return result;
}

public static RL_698f7b78c94e286c7a57a5ca0a521f77 ToList<T>(T[] array, Func <T, RC_e1057cc576f9e6054c23318f5973b604> converter) {
  RL_698f7b78c94e286c7a57a5ca0a521f77 result = new RL_698f7b78c94e286c7a57a5ca0a521f77();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_698f7b78c94e286c7a57a5ca0a521f77 FromRestList<T>(RestList<T> restList, Func <T, RC_e1057cc576f9e6054c23318f5973b604> converter) {
  RL_698f7b78c94e286c7a57a5ca0a521f77 result = new RL_698f7b78c94e286c7a57a5ca0a521f77();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_698f7b78c94e286c7a57a5ca0a521f77() : base() {
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
protected override OSList<RC_e1057cc576f9e6054c23318f5973b604> NewList() {
return new RL_698f7b78c94e286c7a57a5ca0a521f77();
}


} // RL_698f7b78c94e286c7a57a5ca0a521f77
}

