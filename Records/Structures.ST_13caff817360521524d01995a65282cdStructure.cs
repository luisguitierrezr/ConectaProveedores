namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] PostValidacfdiprovResponseWrapper (ZnQ8cyJg8U2waGMYnsUG2Q)
///  <code>ST_13caff817360521524d01995a65282cdStructure</code> that represent
/// s <code>PostValidacfdiprovResponseWrapper</code> <p>Description:
///  PostValidacfdiprovResponseWrapper</p>
/// </summary>
// Name: PostValidacfdiprovResponseWrapper
public partial struct ST_13caff817360521524d01995a65282cdStructure : ITypedRecord<ST_13caff817360521524d01995a65282cdStructure> {
internal static readonly GlobalObjectKey IdCode = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*cAwjygfs00Crc_Gz11d97w");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*MwUAo2BO7U6SwjSyHHFJeQ");
internal static readonly GlobalObjectKey IdValidaCfdResultWrapper = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*BzRHkZZRZ0eVLu81eIhXzA");

public long ssCode;

public string ssMessage;

public ST_b861b971a77239711f72752e074dae26Structure ssValidaCfdResultWrapper;


public BitArray OptimizedAttributes;

public ST_13caff817360521524d01995a65282cdStructure() {
OptimizedAttributes = null;
ssCode = 0L;
ssMessage = "";
ssValidaCfdResultWrapper = new ST_b861b971a77239711f72752e074dae26Structure();
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
    ssValidaCfdResultWrapper.OptimizedAttributes = value[0];
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
ssCode = r.ReadLongInteger(index++, "PostValidacfdiprovResponseWrapper.Code", 0L);
ssMessage = r.ReadText(index++, "PostValidacfdiprovResponseWrapper.Message", "");
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
public void ReadIM(ST_13caff817360521524d01995a65282cdStructure r) {
this = r;
}


public static bool operator == (ST_13caff817360521524d01995a65282cdStructure a, ST_13caff817360521524d01995a65282cdStructure b) {
if (a.ssCode != b.ssCode) return false;
if (a.ssMessage != b.ssMessage) return false;
if (a.ssValidaCfdResultWrapper != b.ssValidaCfdResultWrapper) return false;
return true;
}

public static bool operator != (ST_13caff817360521524d01995a65282cdStructure a, ST_13caff817360521524d01995a65282cdStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_13caff817360521524d01995a65282cdStructure)) return false;
return (this == (ST_13caff817360521524d01995a65282cdStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssCode.GetHashCode()
 ^ ssMessage.GetHashCode()
 ^ ssValidaCfdResultWrapper.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssValidaCfdResultWrapper.RecursiveReset();
}

public void InternalRecursiveSave() {
ssValidaCfdResultWrapper.InternalRecursiveSave();
}


public ST_13caff817360521524d01995a65282cdStructure Duplicate() {
ST_13caff817360521524d01995a65282cdStructure t;
t.ssCode = this.ssCode;
t.ssMessage = this.ssMessage;
t.ssValidaCfdResultWrapper = (ST_b861b971a77239711f72752e074dae26Structure)this.ssValidaCfdResultWrapper.Duplicate();
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
if (head == "code") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Code")) variable.Value = ssCode; else variable.Optimized = true;
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Message")) variable.Value = ssMessage; else variable.Optimized = true;
} else if (head == "validacfdresultwrapper") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ValidaCfdResultWrapper")) variable.Value = ssValidaCfdResultWrapper; else variable.Optimized = true;
variable.SetFieldName("validacfdresultwrapper");
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
if (key == IdCode) {
return ssCode;
}
if (key == IdMessage) {
return ssMessage;
}
if (key == IdValidaCfdResultWrapper) {
return ssValidaCfdResultWrapper;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCode.Key.AsGuid) {
return ssCode;
}
if (attributeKey == IdMessage.Key.AsGuid) {
return ssMessage;
}
if (attributeKey == IdValidaCfdResultWrapper.Key.AsGuid) {
return ssValidaCfdResultWrapper;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssCode = (long) other.AttributeGet(IdCode);
ssMessage = (string) other.AttributeGet(IdMessage);
ssValidaCfdResultWrapper.FillFromOther((IRecord) other.AttributeGet(IdValidaCfdResultWrapper));
}
} // ST_13caff817360521524d01995a65282cdStructure
/// <summary>
/// RecordList type <code>PostValidacfdiprovResponseWrapperList</code> that represents a record list of
///  <code>PostValidacfdiprovResponseWrapper</code>
/// </summary>
public partial class RL_e0ea29f61227e889407341e035989ab6 : GenericRecordList<ST_13caff817360521524d01995a65282cdStructure>, IEnumerable, IEnumerator {

protected override ST_13caff817360521524d01995a65282cdStructure GetElementDefaultValue() {
return new ST_13caff817360521524d01995a65282cdStructure();
}

public T[] ToArray<T>(Func<ST_13caff817360521524d01995a65282cdStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e0ea29f61227e889407341e035989ab6 recordList, Func<ST_13caff817360521524d01995a65282cdStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e0ea29f61227e889407341e035989ab6(ST_13caff817360521524d01995a65282cdStructure[] array) {
  RL_e0ea29f61227e889407341e035989ab6 result = new RL_e0ea29f61227e889407341e035989ab6();
result.InnerFromArray(array);
    return result;
}

public static RL_e0ea29f61227e889407341e035989ab6 ToList<T>(T[] array, Func <T, ST_13caff817360521524d01995a65282cdStructure> converter) {
  RL_e0ea29f61227e889407341e035989ab6 result = new RL_e0ea29f61227e889407341e035989ab6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e0ea29f61227e889407341e035989ab6 FromRestList<T>(RestList<T> restList, Func <T, ST_13caff817360521524d01995a65282cdStructure> converter) {
  RL_e0ea29f61227e889407341e035989ab6 result = new RL_e0ea29f61227e889407341e035989ab6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e0ea29f61227e889407341e035989ab6() : base() {
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
protected override OSList<ST_13caff817360521524d01995a65282cdStructure> NewList() {
return new RL_e0ea29f61227e889407341e035989ab6();
}


} // RL_e0ea29f61227e889407341e035989ab6
}

