namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (RZMo+LBIa06JQtqkrlBjnQ)
///  <code>RC_2fdd8a774a3284e223459de0e7f3cff9</code> that represents <code>TI_WXD_OutRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: TI_WXD_OutRecord
public partial struct RC_2fdd8a774a3284e223459de0e7f3cff9 : ITypedRecord<RC_2fdd8a774a3284e223459de0e7f3cff9> {
internal static readonly GlobalObjectKey IdTI_WXD_Out = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*d4rdLzJK4oQjRZ3g5_PP+Q");

public ST_646bfb521d5f3e3e304163b436da5220Structure ssSTTI_WXD_Out;


public static implicit operator ST_646bfb521d5f3e3e304163b436da5220Structure( RC_2fdd8a774a3284e223459de0e7f3cff9 r) {
return r.ssSTTI_WXD_Out;
}

public static implicit operator RC_2fdd8a774a3284e223459de0e7f3cff9 (ST_646bfb521d5f3e3e304163b436da5220Structure r) {
RC_2fdd8a774a3284e223459de0e7f3cff9 res = new RC_2fdd8a774a3284e223459de0e7f3cff9 ();
res.ssSTTI_WXD_Out = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_2fdd8a774a3284e223459de0e7f3cff9() {
OptimizedAttributes = null;
ssSTTI_WXD_Out = new ST_646bfb521d5f3e3e304163b436da5220Structure();
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
    ssSTTI_WXD_Out.OptimizedAttributes = value[0];
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
ssSTTI_WXD_Out.Read( r, ref index);
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
public void ReadIM(RC_2fdd8a774a3284e223459de0e7f3cff9 r) {
this = r;
}


public static bool operator == (RC_2fdd8a774a3284e223459de0e7f3cff9 a, RC_2fdd8a774a3284e223459de0e7f3cff9 b) {
if (a.ssSTTI_WXD_Out != b.ssSTTI_WXD_Out) return false;
return true;
}

public static bool operator != (RC_2fdd8a774a3284e223459de0e7f3cff9 a, RC_2fdd8a774a3284e223459de0e7f3cff9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2fdd8a774a3284e223459de0e7f3cff9)) return false;
return (this == (RC_2fdd8a774a3284e223459de0e7f3cff9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTTI_WXD_Out.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTTI_WXD_Out.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTTI_WXD_Out.InternalRecursiveSave();
}


public RC_2fdd8a774a3284e223459de0e7f3cff9 Duplicate() {
RC_2fdd8a774a3284e223459de0e7f3cff9 t;
t.ssSTTI_WXD_Out = (ST_646bfb521d5f3e3e304163b436da5220Structure)this.ssSTTI_WXD_Out.Duplicate();
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
if (head == "ti_wxd_out") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TI_WXD_Out")) variable.Value = ssSTTI_WXD_Out; else variable.Optimized = true;
variable.SetFieldName("ti_wxd_out");
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
if (key == IdTI_WXD_Out) {
return ssSTTI_WXD_Out;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTI_WXD_Out.Key.AsGuid) {
return ssSTTI_WXD_Out;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTTI_WXD_Out.FillFromOther((IRecord) other.AttributeGet(IdTI_WXD_Out));
}
} // RC_2fdd8a774a3284e223459de0e7f3cff9
/// <summary>
/// RecordList type <code>TI_WXD_OutRecordList</code> that represents a record list of
///  <code>TI_WXD_Out</code>
/// </summary>
public partial class RL_5852ea7b8760d9c2c9bc8db9aca73318 : GenericRecordList<RC_2fdd8a774a3284e223459de0e7f3cff9>, IEnumerable, IEnumerator {

protected override RC_2fdd8a774a3284e223459de0e7f3cff9 GetElementDefaultValue() {
return new RC_2fdd8a774a3284e223459de0e7f3cff9();
}

public T[] ToArray<T>(Func<RC_2fdd8a774a3284e223459de0e7f3cff9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5852ea7b8760d9c2c9bc8db9aca73318 recordList, Func<RC_2fdd8a774a3284e223459de0e7f3cff9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5852ea7b8760d9c2c9bc8db9aca73318(RC_2fdd8a774a3284e223459de0e7f3cff9[] array) {
  RL_5852ea7b8760d9c2c9bc8db9aca73318 result = new RL_5852ea7b8760d9c2c9bc8db9aca73318();
result.InnerFromArray(array);
    return result;
}

public static RL_5852ea7b8760d9c2c9bc8db9aca73318 ToList<T>(T[] array, Func <T, RC_2fdd8a774a3284e223459de0e7f3cff9> converter) {
  RL_5852ea7b8760d9c2c9bc8db9aca73318 result = new RL_5852ea7b8760d9c2c9bc8db9aca73318();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5852ea7b8760d9c2c9bc8db9aca73318 FromRestList<T>(RestList<T> restList, Func <T, RC_2fdd8a774a3284e223459de0e7f3cff9> converter) {
  RL_5852ea7b8760d9c2c9bc8db9aca73318 result = new RL_5852ea7b8760d9c2c9bc8db9aca73318();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5852ea7b8760d9c2c9bc8db9aca73318() : base() {
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
protected override OSList<RC_2fdd8a774a3284e223459de0e7f3cff9> NewList() {
return new RL_5852ea7b8760d9c2c9bc8db9aca73318();
}


} // RL_5852ea7b8760d9c2c9bc8db9aca73318
}

