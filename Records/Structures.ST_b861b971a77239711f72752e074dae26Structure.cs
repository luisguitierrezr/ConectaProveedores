namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] ValidaCfdResultWrapper (Mx5oF5Ib2kKRzqgdYuxp+A)
///  <code>ST_b861b971a77239711f72752e074dae26Structure</code> that represent
/// s <code>ValidaCfdResultWrapper</code> <p>Description: ValidaCfdResultWrapper</p>
/// </summary>
// Name: ValidaCfdResultWrapper
public partial struct ST_b861b971a77239711f72752e074dae26Structure : ITypedRecord<ST_b861b971a77239711f72752e074dae26Structure> {
internal static readonly GlobalObjectKey IdVigenteSat = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*NgvxtJuS4k2hng1q600Opw");
internal static readonly GlobalObjectKey IdMsgSat = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*ISxz9PRXD0mcTw8rI8eOQQ");
internal static readonly GlobalObjectKey IdExisteUuidSap = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*hXU510_HuUmVvibmSZsI8w");
internal static readonly GlobalObjectKey IdMsgSap = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*zn_xb7yQi06HKwqNWT490A");

public bool ssVigenteSat;

public string ssMsgSat;

public bool ssExisteUuidSap;

public string ssMsgSap;


public BitArray OptimizedAttributes;

public ST_b861b971a77239711f72752e074dae26Structure() {
OptimizedAttributes = null;
ssVigenteSat = false;
ssMsgSat = "";
ssExisteUuidSap = false;
ssMsgSap = "";
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
ssVigenteSat = r.ReadBoolean(index++, "ValidaCfdResultWrapper.VigenteSat", false);
ssMsgSat = r.ReadText(index++, "ValidaCfdResultWrapper.MsgSat", "");
ssExisteUuidSap = r.ReadBoolean(index++, "ValidaCfdResultWrapper.ExisteUuidSap", false);
ssMsgSap = r.ReadText(index++, "ValidaCfdResultWrapper.MsgSap", "");
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
public void ReadIM(ST_b861b971a77239711f72752e074dae26Structure r) {
this = r;
}


public static bool operator == (ST_b861b971a77239711f72752e074dae26Structure a, ST_b861b971a77239711f72752e074dae26Structure b) {
if (a.ssVigenteSat != b.ssVigenteSat) return false;
if (a.ssMsgSat != b.ssMsgSat) return false;
if (a.ssExisteUuidSap != b.ssExisteUuidSap) return false;
if (a.ssMsgSap != b.ssMsgSap) return false;
return true;
}

public static bool operator != (ST_b861b971a77239711f72752e074dae26Structure a, ST_b861b971a77239711f72752e074dae26Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b861b971a77239711f72752e074dae26Structure)) return false;
return (this == (ST_b861b971a77239711f72752e074dae26Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssVigenteSat.GetHashCode()
 ^ ssMsgSat.GetHashCode()
 ^ ssExisteUuidSap.GetHashCode()
 ^ ssMsgSap.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_b861b971a77239711f72752e074dae26Structure Duplicate() {
ST_b861b971a77239711f72752e074dae26Structure t;
t.ssVigenteSat = this.ssVigenteSat;
t.ssMsgSat = this.ssMsgSat;
t.ssExisteUuidSap = this.ssExisteUuidSap;
t.ssMsgSap = this.ssMsgSap;
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
if (head == "vigentesat") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".VigenteSat")) variable.Value = ssVigenteSat; else variable.Optimized = true;
} else if (head == "msgsat") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MsgSat")) variable.Value = ssMsgSat; else variable.Optimized = true;
} else if (head == "existeuuidsap") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExisteUuidSap")) variable.Value = ssExisteUuidSap; else variable.Optimized = true;
} else if (head == "msgsap") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MsgSap")) variable.Value = ssMsgSap; else variable.Optimized = true;
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
if (key == IdVigenteSat) {
return ssVigenteSat;
}
if (key == IdMsgSat) {
return ssMsgSat;
}
if (key == IdExisteUuidSap) {
return ssExisteUuidSap;
}
if (key == IdMsgSap) {
return ssMsgSap;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdVigenteSat.Key.AsGuid) {
return ssVigenteSat;
}
if (attributeKey == IdMsgSat.Key.AsGuid) {
return ssMsgSat;
}
if (attributeKey == IdExisteUuidSap.Key.AsGuid) {
return ssExisteUuidSap;
}
if (attributeKey == IdMsgSap.Key.AsGuid) {
return ssMsgSap;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssVigenteSat = (bool) other.AttributeGet(IdVigenteSat);
ssMsgSat = (string) other.AttributeGet(IdMsgSat);
ssExisteUuidSap = (bool) other.AttributeGet(IdExisteUuidSap);
ssMsgSap = (string) other.AttributeGet(IdMsgSap);
}
} // ST_b861b971a77239711f72752e074dae26Structure
/// <summary>
/// RecordList type <code>ValidaCfdResultWrapperList</code> that represents a record list of
///  <code>ValidaCfdResultWrapper</code>
/// </summary>
public partial class RL_179dff6222b287e412a33c9c8ee3236a : GenericRecordList<ST_b861b971a77239711f72752e074dae26Structure>, IEnumerable, IEnumerator {

protected override ST_b861b971a77239711f72752e074dae26Structure GetElementDefaultValue() {
return new ST_b861b971a77239711f72752e074dae26Structure();
}

public T[] ToArray<T>(Func<ST_b861b971a77239711f72752e074dae26Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_179dff6222b287e412a33c9c8ee3236a recordList, Func<ST_b861b971a77239711f72752e074dae26Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_179dff6222b287e412a33c9c8ee3236a(ST_b861b971a77239711f72752e074dae26Structure[] array) {
  RL_179dff6222b287e412a33c9c8ee3236a result = new RL_179dff6222b287e412a33c9c8ee3236a();
result.InnerFromArray(array);
    return result;
}

public static RL_179dff6222b287e412a33c9c8ee3236a ToList<T>(T[] array, Func <T, ST_b861b971a77239711f72752e074dae26Structure> converter) {
  RL_179dff6222b287e412a33c9c8ee3236a result = new RL_179dff6222b287e412a33c9c8ee3236a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_179dff6222b287e412a33c9c8ee3236a FromRestList<T>(RestList<T> restList, Func <T, ST_b861b971a77239711f72752e074dae26Structure> converter) {
  RL_179dff6222b287e412a33c9c8ee3236a result = new RL_179dff6222b287e412a33c9c8ee3236a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_179dff6222b287e412a33c9c8ee3236a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_b861b971a77239711f72752e074dae26Structure> NewList() {
return new RL_179dff6222b287e412a33c9c8ee3236a();
}


} // RL_179dff6222b287e412a33c9c8ee3236a
}

