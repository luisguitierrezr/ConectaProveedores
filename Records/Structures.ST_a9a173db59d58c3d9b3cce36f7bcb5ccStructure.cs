namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] EM_SM_MO_COSMOZ_Response_Struct (Vc8wWmQWlUep+3pFMGfzLA)
///  <code>ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure</code> that represent
/// s <code>EM_SM_MO_COSMOZ_Response_Struct</code> <p>Description: EM_SM_MO_COSMOZ_Response_Struct</p>
/// </summary>
// Name: EM_SM_MO_COSMOZ_Response_Struct
public partial struct ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure : ITypedRecord<ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure> {
internal static readonly GlobalObjectKey IdPO_DESCRIPCION_ERROR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*8rgjw+KGH0SaKW3_GPC1dA");
internal static readonly GlobalObjectKey IdPO_DOCUMENTO_MATERIAL_221 = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*9HkRouttFkqreN+5ERUIBA");
internal static readonly GlobalObjectKey IdPO_DOCUMENTO_MATERIAL_415 = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*8Zen_NfSjUmi5BuhZH_CZQ");
internal static readonly GlobalObjectKey IdPO_DOCUMENTO_MATERIAL_EM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*CJZSXNpdpkunNbr6naev5A");
internal static readonly GlobalObjectKey IdPO_EJERCICIO_221 = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*0pGp_bS6y0yB+kgix89sIA");
internal static readonly GlobalObjectKey IdPO_EJERCICIO_415 = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*8o4dIcRPX0KFsFdL5Kl5uA");
internal static readonly GlobalObjectKey IdPO_EJERCICIO_EM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*V_ZzF7qWuU2aruCpprw+GA");
internal static readonly GlobalObjectKey IdPO_NUMERO_ERROR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*j76F86iQrEmVsbXtnmnnrg");
internal static readonly GlobalObjectKey IdPO_RESULTADO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*b2sxRQ+qDkOIxdVJn2HM9Q");

public string ssPO_DESCRIPCION_ERROR;

public string ssPO_DOCUMENTO_MATERIAL_221;

public string ssPO_DOCUMENTO_MATERIAL_415;

public string ssPO_DOCUMENTO_MATERIAL_EM;

public string ssPO_EJERCICIO_221;

public string ssPO_EJERCICIO_415;

public string ssPO_EJERCICIO_EM;

public string ssPO_NUMERO_ERROR;

public string ssPO_RESULTADO;


public BitArray OptimizedAttributes;

public ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure() {
OptimizedAttributes = null;
ssPO_DESCRIPCION_ERROR = "";
ssPO_DOCUMENTO_MATERIAL_221 = "";
ssPO_DOCUMENTO_MATERIAL_415 = "";
ssPO_DOCUMENTO_MATERIAL_EM = "";
ssPO_EJERCICIO_221 = "";
ssPO_EJERCICIO_415 = "";
ssPO_EJERCICIO_EM = "";
ssPO_NUMERO_ERROR = "";
ssPO_RESULTADO = "";
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
ssPO_DESCRIPCION_ERROR = r.ReadText(index++, "EM_SM_MO_COSMOZ_Response_Struct.PO_DESCRIPCION_ERROR", "");
ssPO_DOCUMENTO_MATERIAL_221 = r.ReadText(index++, "EM_SM_MO_COSMOZ_Response_Struct.PO_DOCUMENTO_MATERIAL_221", "");
ssPO_DOCUMENTO_MATERIAL_415 = r.ReadText(index++, "EM_SM_MO_COSMOZ_Response_Struct.PO_DOCUMENTO_MATERIAL_415", "");
ssPO_DOCUMENTO_MATERIAL_EM = r.ReadText(index++, "EM_SM_MO_COSMOZ_Response_Struct.PO_DOCUMENTO_MATERIAL_EM", "");
ssPO_EJERCICIO_221 = r.ReadText(index++, "EM_SM_MO_COSMOZ_Response_Struct.PO_EJERCICIO_221", "");
ssPO_EJERCICIO_415 = r.ReadText(index++, "EM_SM_MO_COSMOZ_Response_Struct.PO_EJERCICIO_415", "");
ssPO_EJERCICIO_EM = r.ReadText(index++, "EM_SM_MO_COSMOZ_Response_Struct.PO_EJERCICIO_EM", "");
ssPO_NUMERO_ERROR = r.ReadText(index++, "EM_SM_MO_COSMOZ_Response_Struct.PO_NUMERO_ERROR", "");
ssPO_RESULTADO = r.ReadText(index++, "EM_SM_MO_COSMOZ_Response_Struct.PO_RESULTADO", "");
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
public void ReadIM(ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure r) {
this = r;
}


public static bool operator == (ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure a, ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure b) {
if (a.ssPO_DESCRIPCION_ERROR != b.ssPO_DESCRIPCION_ERROR) return false;
if (a.ssPO_DOCUMENTO_MATERIAL_221 != b.ssPO_DOCUMENTO_MATERIAL_221) return false;
if (a.ssPO_DOCUMENTO_MATERIAL_415 != b.ssPO_DOCUMENTO_MATERIAL_415) return false;
if (a.ssPO_DOCUMENTO_MATERIAL_EM != b.ssPO_DOCUMENTO_MATERIAL_EM) return false;
if (a.ssPO_EJERCICIO_221 != b.ssPO_EJERCICIO_221) return false;
if (a.ssPO_EJERCICIO_415 != b.ssPO_EJERCICIO_415) return false;
if (a.ssPO_EJERCICIO_EM != b.ssPO_EJERCICIO_EM) return false;
if (a.ssPO_NUMERO_ERROR != b.ssPO_NUMERO_ERROR) return false;
if (a.ssPO_RESULTADO != b.ssPO_RESULTADO) return false;
return true;
}

public static bool operator != (ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure a, ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure)) return false;
return (this == (ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPO_DESCRIPCION_ERROR.GetHashCode()
 ^ ssPO_DOCUMENTO_MATERIAL_221.GetHashCode()
 ^ ssPO_DOCUMENTO_MATERIAL_415.GetHashCode()
 ^ ssPO_DOCUMENTO_MATERIAL_EM.GetHashCode()
 ^ ssPO_EJERCICIO_221.GetHashCode()
 ^ ssPO_EJERCICIO_415.GetHashCode()
 ^ ssPO_EJERCICIO_EM.GetHashCode()
 ^ ssPO_NUMERO_ERROR.GetHashCode()
 ^ ssPO_RESULTADO.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure Duplicate() {
ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure t;
t.ssPO_DESCRIPCION_ERROR = this.ssPO_DESCRIPCION_ERROR;
t.ssPO_DOCUMENTO_MATERIAL_221 = this.ssPO_DOCUMENTO_MATERIAL_221;
t.ssPO_DOCUMENTO_MATERIAL_415 = this.ssPO_DOCUMENTO_MATERIAL_415;
t.ssPO_DOCUMENTO_MATERIAL_EM = this.ssPO_DOCUMENTO_MATERIAL_EM;
t.ssPO_EJERCICIO_221 = this.ssPO_EJERCICIO_221;
t.ssPO_EJERCICIO_415 = this.ssPO_EJERCICIO_415;
t.ssPO_EJERCICIO_EM = this.ssPO_EJERCICIO_EM;
t.ssPO_NUMERO_ERROR = this.ssPO_NUMERO_ERROR;
t.ssPO_RESULTADO = this.ssPO_RESULTADO;
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
if (head == "po_descripcion_error") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_DESCRIPCION_ERROR")) variable.Value = ssPO_DESCRIPCION_ERROR; else variable.Optimized = true;
} else if (head == "po_documento_material_221") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_DOCUMENTO_MATERIAL_221")) variable.Value = ssPO_DOCUMENTO_MATERIAL_221; else variable.Optimized = true;
} else if (head == "po_documento_material_415") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_DOCUMENTO_MATERIAL_415")) variable.Value = ssPO_DOCUMENTO_MATERIAL_415; else variable.Optimized = true;
} else if (head == "po_documento_material_em") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_DOCUMENTO_MATERIAL_EM")) variable.Value = ssPO_DOCUMENTO_MATERIAL_EM; else variable.Optimized = true;
} else if (head == "po_ejercicio_221") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_EJERCICIO_221")) variable.Value = ssPO_EJERCICIO_221; else variable.Optimized = true;
} else if (head == "po_ejercicio_415") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_EJERCICIO_415")) variable.Value = ssPO_EJERCICIO_415; else variable.Optimized = true;
} else if (head == "po_ejercicio_em") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_EJERCICIO_EM")) variable.Value = ssPO_EJERCICIO_EM; else variable.Optimized = true;
} else if (head == "po_numero_error") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_NUMERO_ERROR")) variable.Value = ssPO_NUMERO_ERROR; else variable.Optimized = true;
} else if (head == "po_resultado") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_RESULTADO")) variable.Value = ssPO_RESULTADO; else variable.Optimized = true;
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
if (key == IdPO_DESCRIPCION_ERROR) {
return ssPO_DESCRIPCION_ERROR;
}
if (key == IdPO_DOCUMENTO_MATERIAL_221) {
return ssPO_DOCUMENTO_MATERIAL_221;
}
if (key == IdPO_DOCUMENTO_MATERIAL_415) {
return ssPO_DOCUMENTO_MATERIAL_415;
}
if (key == IdPO_DOCUMENTO_MATERIAL_EM) {
return ssPO_DOCUMENTO_MATERIAL_EM;
}
if (key == IdPO_EJERCICIO_221) {
return ssPO_EJERCICIO_221;
}
if (key == IdPO_EJERCICIO_415) {
return ssPO_EJERCICIO_415;
}
if (key == IdPO_EJERCICIO_EM) {
return ssPO_EJERCICIO_EM;
}
if (key == IdPO_NUMERO_ERROR) {
return ssPO_NUMERO_ERROR;
}
if (key == IdPO_RESULTADO) {
return ssPO_RESULTADO;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPO_DESCRIPCION_ERROR.Key.AsGuid) {
return ssPO_DESCRIPCION_ERROR;
}
if (attributeKey == IdPO_DOCUMENTO_MATERIAL_221.Key.AsGuid) {
return ssPO_DOCUMENTO_MATERIAL_221;
}
if (attributeKey == IdPO_DOCUMENTO_MATERIAL_415.Key.AsGuid) {
return ssPO_DOCUMENTO_MATERIAL_415;
}
if (attributeKey == IdPO_DOCUMENTO_MATERIAL_EM.Key.AsGuid) {
return ssPO_DOCUMENTO_MATERIAL_EM;
}
if (attributeKey == IdPO_EJERCICIO_221.Key.AsGuid) {
return ssPO_EJERCICIO_221;
}
if (attributeKey == IdPO_EJERCICIO_415.Key.AsGuid) {
return ssPO_EJERCICIO_415;
}
if (attributeKey == IdPO_EJERCICIO_EM.Key.AsGuid) {
return ssPO_EJERCICIO_EM;
}
if (attributeKey == IdPO_NUMERO_ERROR.Key.AsGuid) {
return ssPO_NUMERO_ERROR;
}
if (attributeKey == IdPO_RESULTADO.Key.AsGuid) {
return ssPO_RESULTADO;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPO_DESCRIPCION_ERROR = (string) other.AttributeGet(IdPO_DESCRIPCION_ERROR);
ssPO_DOCUMENTO_MATERIAL_221 = (string) other.AttributeGet(IdPO_DOCUMENTO_MATERIAL_221);
ssPO_DOCUMENTO_MATERIAL_415 = (string) other.AttributeGet(IdPO_DOCUMENTO_MATERIAL_415);
ssPO_DOCUMENTO_MATERIAL_EM = (string) other.AttributeGet(IdPO_DOCUMENTO_MATERIAL_EM);
ssPO_EJERCICIO_221 = (string) other.AttributeGet(IdPO_EJERCICIO_221);
ssPO_EJERCICIO_415 = (string) other.AttributeGet(IdPO_EJERCICIO_415);
ssPO_EJERCICIO_EM = (string) other.AttributeGet(IdPO_EJERCICIO_EM);
ssPO_NUMERO_ERROR = (string) other.AttributeGet(IdPO_NUMERO_ERROR);
ssPO_RESULTADO = (string) other.AttributeGet(IdPO_RESULTADO);
}
} // ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure
/// <summary>
/// RecordList type <code>EM_SM_MO_COSMOZ_Response_StructList</code> that represents a record list of
///  <code>EM_SM_MO_COSMOZ_Response_Struct</code>
/// </summary>
public partial class RL_e8959a57bd27b75fbc4fab7cb94ec840 : GenericRecordList<ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure>, IEnumerable, IEnumerator {

protected override ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure GetElementDefaultValue() {
return new ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure();
}

public T[] ToArray<T>(Func<ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e8959a57bd27b75fbc4fab7cb94ec840 recordList, Func<ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e8959a57bd27b75fbc4fab7cb94ec840(ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure[] array) {
  RL_e8959a57bd27b75fbc4fab7cb94ec840 result = new RL_e8959a57bd27b75fbc4fab7cb94ec840();
result.InnerFromArray(array);
    return result;
}

public static RL_e8959a57bd27b75fbc4fab7cb94ec840 ToList<T>(T[] array, Func <T, ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure> converter) {
  RL_e8959a57bd27b75fbc4fab7cb94ec840 result = new RL_e8959a57bd27b75fbc4fab7cb94ec840();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e8959a57bd27b75fbc4fab7cb94ec840 FromRestList<T>(RestList<T> restList, Func <T, ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure> converter) {
  RL_e8959a57bd27b75fbc4fab7cb94ec840 result = new RL_e8959a57bd27b75fbc4fab7cb94ec840();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e8959a57bd27b75fbc4fab7cb94ec840() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure> NewList() {
return new RL_e8959a57bd27b75fbc4fab7cb94ec840();
}


} // RL_e8959a57bd27b75fbc4fab7cb94ec840
}

